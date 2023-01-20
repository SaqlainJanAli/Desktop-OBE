using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL.Assessment;
using OBE_BEL.ViewModels;

namespace OBE_DAL.MyInstitute_DAL.CourseSection.Assessment
{
    public class MarksGPA_DAL
    {
        //Save
        public ResultModel SaveCourseSecResultsDAL(List<StudentCourseSectionResult> courseSectionResults)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new ApplicationDbContext())
                {

                    foreach (var item in courseSectionResults)
                    {
                        //Check if result for this student in this course section exist or not 
                            //If Yes Then Update Otherwise Save It
                        var ent = _dbContext.StudentCourseSectionResults.FirstOrDefault(s =>
                            s.StudentId == item.StudentId && s.CourseSecId == item.CourseSecId);
                        if (ent != null)
                        {
                            ent.Assignment1 = item.Assignment1;
                            ent.Assignment2 = item.Assignment2;
                            ent.Assignment3 = item.Assignment3;
                            ent.Assignment4 = item.Assignment4;

                            ent.Quiz1 = item.Quiz1;
                            ent.Quiz2 = item.Quiz2;
                            ent.Quiz3 = item.Quiz3;
                            ent.Quiz4 = item.Quiz4;

                            ent.Midterm = item.Midterm;
                            ent.Terminal = item.Terminal;

                            ent.Name = item.Name;
                            ent.RegistrationNo = item.RegistrationNo;
                            ent.Grade = item.Grade;
                            ent.Percentage = item.Percentage;
                            ent.TotalMarks = item.TotalMarks;
                        }
                        else
                        {
                            _dbContext.StudentCourseSectionResults.Add(item);
                        }

                        _dbContext.SaveChanges();
                    }
                    //_dbContext.StudentCourseSectionResults.AddRange(courseSectionResults);
                    //_dbContext.SaveChanges();
                    return new ResultModel()
                    {
                        Data = null,
                        Message = "Result successfully saved",
                        Status = true
                    };
                }
            }
            catch (Exception e)
            {
                return new ResultModel()
                {
                    Data = null,
                    Message = e.Message,
                    Status = false
                };
            }
        }

        //Read
        public List<StudentCourseSectionResult> GetActiviyResultsDAL(int courseSecId)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                //Enrolled Students
                var enrolledStudents =
                    _dbContext.EnrollStudents.Where(es => es.CourseSectionId == courseSecId).ToList();

                //ActivityTypesIDs
                var activityTypes = _dbContext.Activities.Where(at => at.CourseSectionId == courseSecId).ToList();
                List<int> _assignmentIds = new List<int>();
                List<int> _quizIds = new List<int>();
                List<int> _midtermIds = new List<int>();
                List<int> _finalIds = new List<int>();

                int _assignmentId = 0;
                int _quizId = 0;
                int _midtermId = 0;
                int _finalId = 0;
                int _labid = 0;
                foreach (var activityType in activityTypes)
                {
                    if (activityType.Name.StartsWith("A"))
                    {

                        _assignmentId = activityType.Id;
                    }
                    else if (activityType.Name.StartsWith("Q"))
                    {
                        _quizId = activityType.Id;
                    }
                    else if (activityType.Name.StartsWith("M"))
                    {
                        _midtermId = activityType.Id;
                    }
                    else if (activityType.Name.StartsWith("F"))
                    {
                        _finalId = activityType.Id;
                    }
                }

                var ListofResults = new List<StudentCourseSectionResult>();


                foreach (var enrolledStudent in enrolledStudents)
                {

                    //Activity wise results of this student in this course section
                    var activityResults = _dbContext.ClassActivityResults.Where(car =>
                            car.CourseSecId == courseSecId && car.StudentUserId == enrolledStudent.StudentUserId)
                        .ToList();

                    //List of Class Activities in this course section
                    var listOfClassAct = _dbContext.ClassActivities.Where(ca => ca.CourseSecId == courseSecId).ToList();

                    //Results of this Student will be stored here
                    var resultBEL = new StudentCourseSectionResult();
                    resultBEL.CourseSecId = courseSecId;
                    resultBEL.StudentId = enrolledStudent.StudentUserId;

                    //getting reg no and name
                    var stdUser = _dbContext.StudentUsers.FirstOrDefault(su => su.Id == enrolledStudent.StudentUserId);
                    resultBEL.Name = stdUser.Name;
                    resultBEL.RegistrationNo = stdUser.RegistrationNo;

                    //Searching
                    int i = 1;
                    int j = 1;
                    foreach (var carItem in activityResults)
                    {
                        //int i = 1;
                        //int j = 1;
                        //carItem.cl
                        foreach (var classActivity in listOfClassAct.Where(ca =>
                            carItem.ClassActivityId == ca.Id))
                        {

                            //Assignments
                            if (i == 1)
                            {
                                if (classActivity.ActivityId == _assignmentId && classActivity.Name.StartsWith("A"))
                                {
                                    resultBEL.Assignment1 = carItem.ActivityObtainedMarks;
                                    i++;
                                }

                            }

                            else if (i == 2)
                            {
                                if (classActivity.ActivityId == _assignmentId && classActivity.Name.StartsWith("A"))
                                {
                                    resultBEL.Assignment2 = carItem.ActivityObtainedMarks;
                                    i++;
                                }
                            }
                            else if (i == 3)
                            {
                                if (classActivity.ActivityId == _assignmentId && classActivity.Name.StartsWith("A"))
                                {
                                    resultBEL.Assignment3 = carItem.ActivityObtainedMarks;
                                    i++;
                                }
                            }
                            else if (i == 4)
                            {
                                if (classActivity.ActivityId == _assignmentId && classActivity.Name.StartsWith("A"))
                                {
                                    resultBEL.Assignment4 = carItem.ActivityObtainedMarks;
                                    i++;
                                }
                            }

                            //Quizes
                            if (j == 1)
                            {
                                if (classActivity.ActivityId == _quizId && classActivity.Name.StartsWith("Q") ||
                                    classActivity.Name.StartsWith("q"))
                                {
                                    resultBEL.Quiz1 = carItem.ActivityObtainedMarks;
                                    j++;
                                }
                            }
                            else if (j == 2)
                            {
                                if (classActivity.ActivityId == _assignmentId && classActivity.Name.StartsWith("A"))
                                {
                                    resultBEL.Quiz2 = carItem.ActivityObtainedMarks;
                                    i++;
                                }
                            }
                            else if (j == 3)
                            {
                                if (classActivity.ActivityId == _assignmentId && classActivity.Name.StartsWith("A"))
                                {
                                    resultBEL.Quiz3 = carItem.ActivityObtainedMarks;
                                    i++;
                                }
                            }
                            else if (j == 4)
                            {
                                if (classActivity.ActivityId == _assignmentId && classActivity.Name.StartsWith("A"))
                                {
                                    resultBEL.Quiz4 = carItem.ActivityObtainedMarks;
                                    i++;
                                }
                            }

                            //MidTerm
                            if (classActivity.ActivityId == _midtermId)
                            {
                                resultBEL.Midterm = carItem.ActivityObtainedMarks;
                            }
                            //Final
                            if (classActivity.ActivityId == _finalId)
                            {
                                resultBEL.Terminal = carItem.ActivityObtainedMarks;
                            }
                        } //End of foreach of class activiity
                    } //End of activity results



                    //Sum of assignments
                    decimal sumOfAssignments = resultBEL.Assignment1 + resultBEL.Assignment2 + resultBEL.Assignment3 +
                                               resultBEL.Assignment4;
                    //Sum of quizes marks
                    decimal sumOfQuizes = resultBEL.Quiz1 + resultBEL.Quiz2 + resultBEL.Quiz3 +
                                          resultBEL.Quiz4;

                    //Total Marks
                    resultBEL.TotalMarks = sumOfAssignments + sumOfQuizes + resultBEL.Midterm + resultBEL.Terminal;

                    //Percentage
                    resultBEL.Percentage = (resultBEL.TotalMarks / 100) * 100;

                    decimal percentage = resultBEL.Percentage;
                    //Getting grade
                    if (percentage > 0 & percentage < 100)
                    {
                        if (percentage >= 85)
                        {
                            resultBEL.Grade = "A";
                            //4
                        }

                        if (percentage >= 80 & percentage < 85)
                        {
                            resultBEL.Grade = "A-";
                            //3.66
                        }

                        if (percentage >= 75 & percentage < 80)
                        {
                            resultBEL.Grade = "B+";
                            //3.33
                        }

                        if (percentage >= 71 & percentage < 75)
                        {
                            resultBEL.Grade = "B";
                            //3.00
                        }

                        if (percentage >= 68 & percentage < 71)
                        {
                            resultBEL.Grade = "B-";
                            //2.66
                        }

                        if (percentage >= 64 & percentage < 67)
                        {
                            resultBEL.Grade = "C+";
                            //2.33
                        }

                        if (percentage >= 61 & percentage < 64)
                        {
                            resultBEL.Grade = "C";
                            //2.00
                        }

                        if (percentage >= 58 & percentage < 61)
                        {
                            resultBEL.Grade = "C-";
                            //1.66
                        }

                        if (percentage >= 54 & percentage < 58)
                        {
                            resultBEL.Grade = "D+";
                            //1.33
                        }

                        if (percentage >= 50 & percentage < 54)
                        {
                            resultBEL.Grade = "D";
                            //1.00
                        }

                        if (percentage < 50)
                        {
                            resultBEL.Grade = "F";
                            //0.0
                        }
                    }

                    //Adding to returning list
                    ListofResults.Add(resultBEL);
                } //End of enrolled student foreach
                return ListofResults;
            } //end of using method
        }
    }
}