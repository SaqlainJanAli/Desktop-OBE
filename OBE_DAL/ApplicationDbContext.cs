using System.Data.Entity;
using OBE_BEL.Admin_Section.RolesBEL;
using OBE_BEL.Admin_Section.RolesBEL.RoleBEL;
using OBE_BEL.Admin_Section.RolesBEL.RolePrivacyBEL;
using OBE_BEL.Admin_Section.StudentUserBEL;
using OBE_BEL.Admin_Section.UserBEL;
using OBE_BEL.Assessment_Section;
using OBE_BEL.Assessment_Section.ActivityBEL;
using OBE_BEL.MyInstitute_Section;
using OBE_BEL.MyInstitute_Section.CampusesBEL;
using OBE_BEL.MyInstitute_Section.CourseBEL;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL.ActivityWeight;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL.Assessment;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL.Class_Students;
using OBE_BEL.MyInstitute_Section.DepartmentBEL;
using OBE_BEL.MyInstitute_Section.GpaBEL;
using OBE_BEL.MyInstitute_Section.InstituteBEL;
using OBE_BEL.MyInstitute_Section.ProgramBatchBEL;
using OBE_BEL.MyInstitute_Section.ProgramBEL;
using OBE_BEL.MyInstitute_Section.SchoolsBEL;
using OBE_BEL.MyInstitute_Section.SemesterBEL;
using OBE_BEL.OBE_Section.PEO_BEL;
using OBE_BEL.OBE_Section.PLO_BEL;
using OBE_BEL.OBE_Section.CLO_BEL;

namespace OBE_DAL
{
    public class ApplicationDbContext : DbContext
    {
        //Institutes
        
        public DbSet<Type> Types { get; set; }
        public DbSet<PLOCalculationMethod> PloCalculationMethods { get; set; }
        public DbSet<IssuingAuthority> IssuingAuthorities { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Institute> Institutes{ get; set; }

        //Campus
        public DbSet<Campus> Campuses { get; set; }

        //School
        public DbSet<School> Schools { get; set; }

        //Department
        public DbSet<GPA_Method> GPAMethods{ get; set; }
        public DbSet<AssessmentMethod> AssessmentMethods { get; set; }
        public DbSet<Department> Departments { get; set; }


        //Semester
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<SemesterType> SemesterTypes{ get; set; }



        //Programs
        public DbSet<ProgramLevel> ProgramLevels { get; set; }
        public DbSet<LearningType> LearningTypes{ get; set; }
        public DbSet<NoOfSession> NoOfSessions{ get; set; }
        public DbSet<Program> Programs{ get; set; }

        //ProgramBatch
        public DbSet<ProgramBatch> ProgramBatches { get; set; }


        //Courses
        public DbSet<KnowledgeProfile> KnowledgeProfiles { get; set; }
        public DbSet<KnowledgeArea> KnowledgeAreas { get; set; }
        public DbSet<DeliveryFormat> DeliveryFormats { get; set; }
        public DbSet<CourseLevel> CourseLevels { get; set; }
        public DbSet <Course> Courses{ get; set; }
        public DbSet<ProgramCourse> ProgramCourses { get; set; }
        public DbSet<BaseType> BaseTypes { get; set; }



        //Users & Roles
        public DbSet<Role> Roles { get; set; }
        public DbSet<Gender> Genders{ get; set; }
        public DbSet<RoleType> RoleTypes { get; set; }

        //FacultyUser
        public DbSet<FType> FTypes { get; set; }
        public DbSet<FacultyType> FacultyTypes{ get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<FacultyUser> FacultyUsers{ get; set; }


        //CourseSection
        public DbSet<CourseSection> CourseSections { get; set; }

        //Roles Privacy
        public DbSet<RolePrivacy> RolePrivacies { get; set; }

        //PEO
        public DbSet<PEO> PEOs { get; set; }
        public DbSet<PEOProgram> PEOPrograms { get; set; }

        //PLO
        public DbSet<PLO> PLOs { get; set; }
        public DbSet<PLOProfile> PLOProfiles { get; set; }

        //CLO
        public DbSet<CLO> CLOs { get; set; }
        public DbSet<CLOType> CLOTypes { get; set; }
        public DbSet<CLOCourse> CLOCourses { get; set; }

        //Activity
        public DbSet<AllowedOperation> AllowedOperations  { get; set; }
        public DbSet<Activity> Activities { get; set; }

        //Class Activity
        public DbSet<ClassActivity> ClassActivities { get; set; }
        public DbSet<SubActivity> SubActivities { get; set; }
        
        //Student Users
        public DbSet<Religion> Religions { get; set; }
        public DbSet<Province> Regions { get; set; }

        public DbSet<Status> Statuses { get; set; }
        public DbSet<StudyMode> StudyModes { get; set; }
        public DbSet<Quota> Quotas { get; set; }
        public DbSet<AdmissionCategory> AdmissionCategories { get; set; }
        public DbSet<AdmissionType> AdmissionTypes { get; set; }
        public DbSet<HSSCType> HsscTypes { get; set; }

        public DbSet<BScType> BScTypes { get; set; }

        public DbSet<StudentUser> StudentUsers { get; set; }


        //Class Students
        public DbSet<EnrollStudent> EnrollStudents { get; set; }

        //Activity Weight
        public DbSet<ActivityWeight> ActivityWeights { get; set; }

        //Activity Result
        public DbSet<ClassActivityResult> ClassActivityResults { get; set; }
        
        //Student Users Results
        public DbSet<StudentCourseSectionResult> StudentCourseSectionResults { get; set; }

        //Semester result
        public DbSet<StudentSemesterResult> StudentSemesterResults { get; set; }


        public ApplicationDbContext() : base("name=con")
        {



        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<EnrollStudent>().HasKey(es => new {es.Id, es.CourseSectionId, es.StudentUserId});
            base.OnModelCreating(modelBuilder);
        }
    }
}
