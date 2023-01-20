using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.IO;
using OBE_BEL.Admin_Section.RolesBEL;
using OBE_BEL.MyInstitute_Section.InstituteBEL;
using OBE_BEL.MyInstitute_Section.ProgramBatchBEL;

namespace OBE_BEL.Admin_Section.StudentUserBEL
{
    public class StudentUser
    {
        [Key]
        [Column(Order = 1)]
        public int Id { get; set; }



        [Required]
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //[Column(Order = 2)]
        public string RegistrationNo { get; set; }
        [Required]
        public string Name { get; set; }

        public string RollNo { get; set; }
        public string ERPId { get; set; }
        public ProgramBatch ProgramBatch { get; set; }
        [ForeignKey("ProgramBatch")]
        public int? ProgramBatchId { get; set; }

        public Gender Gender { get; set; }
        [ForeignKey("Gender")]
        public int? GenderId { get; set; }


        public Religion Religion { get; set; }
        [ForeignKey("Religion")]
        public int? ReligionId { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public StudyMode StudyMode { get; set; }
        [ForeignKey("StudyMode")]
        public int StudyModeId { get; set; }


        public Status Status { get; set; }
        [ForeignKey("Status")]
        public int StatusId { get; set; }

        public bool isLocal { get; set; }

        public string FatherName { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Required]
        public string CNIC { get; set; }
        public string Passport { get; set; }

        [Phone]
        public string PhoneNo { get; set; }


        [Phone]
        public string MobileNo { get; set; }

        public string PermanentAddress { get; set; }

        public City City { get; set; }
        [ForeignKey("City")]
        public int CityId { get; set; }


        public string District { get; set; }

        public Province Region { get; set; }
        [ForeignKey("Region")]
        public int RegionId { get; set; }

        public Country Country { get; set; }
        [ForeignKey("Country")]
        public int CountryId { get; set; }
        [Required]
        public string PostalAddress { get; set; }

        public HSSCType HSSCType { get; set; }
        [ForeignKey("HSSCType")]
        public int HsscTypeId { get; set; }

        public decimal HsscMarksPercent { get; set; }

        public BScType BScType { get; set; }
        [ForeignKey("BScType")]
        public int BscTypeId { get; set; }
    
        public decimal BscMarksPercent { get; set; }

        public decimal EntryTestMarks { get; set; }

        public Quota Quota { get; set; }
        [ForeignKey("Quota")]
        public int QuotaId { get; set; }

        public string ApplicationNo { get; set; }
        [DataType(DataType.Date)]
        public DateTime AdmissionDate { get; set; }

        public AdmissionType AdmissionType { get; set; }
        [ForeignKey("AdmissionType")]
        public int? AdmissionTypeId { get; set; }

        public AdmissionCategory AdmissionCategory { get; set; }
        [ForeignKey("AdmissionCategory")]
        public int? AdmissionCategoryId { get; set; }

        public string ExtraNotes { get; set; }

        public string ImagePath { get; set; }


        //One to one relatio

        [NotMapped]
        public Image Image
        {
            get
            {
                if ((!string.IsNullOrEmpty(ImagePath)))
                {
                    if (File.Exists(ImagePath))
                    {
                        return Image.FromFile(ImagePath);
                    }

                }
                return null;
            }

        }
    }
}
