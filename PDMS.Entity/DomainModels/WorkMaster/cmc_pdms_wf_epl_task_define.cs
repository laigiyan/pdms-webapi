/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果数据库字段发生变化，请在代码生器重新生成此Model
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDMS.Entity.SystemModels;

namespace PDMS.Entity.DomainModels
{
    [Entity(TableCnName = "wf_epl_task_define",TableName = "cmc_pdms_wf_epl_task_define",DBServer = "SysDbContext")]
    public partial class cmc_pdms_wf_epl_task_define:SysEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="wf_epl_task_define_id")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid wf_epl_task_define_id { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="wf_master_id")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid wf_master_id { get; set; }

        [Display(Name = "project_task_id")]
        [Column(TypeName = "uniqueidentifier")]
        [Editable(true)]
        [Required(AllowEmptyStrings = false)]
        public Guid project_task_id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Display(Name ="epl_id")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid epl_id { get; set; }

       /// <summary>
       ///新增、修改、刪除
       /// </summary>
       [Display(Name ="新增、修改、刪除")]
       [MaxLength(2)]
       [Column(TypeName="varchar(20)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string action_type { get; set; }

       /// <summary>
       ///審核狀態
       /// </summary>
       [Display(Name ="審核狀態")]
       [MaxLength(2)]
       [Column(TypeName="varchar(2)")]
       [Editable(true)]
       public string approve_status { get; set; }

       /// <summary>
       ///完成標識
       /// </summary>
       [Display(Name ="完成標識")]
       [MaxLength(2)]
       [Column(TypeName="varchar(2)")]
       [Editable(true)]
       public string done_status { get; set; }

       /// <summary>
       ///是否重點審查項目
       /// </summary>
       [Display(Name ="是否重點審查項目")]
       [MaxLength(1)]
       [Column(TypeName="varchar(1)")]
       [Editable(true)]
       public string check_flag { get; set; }

       /// <summary>
       ///工作計劃模板
       /// </summary>
       [Display(Name ="工作計劃模板")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? template_id { get; set; }

       /// <summary>
       ///任務模板ID
       /// </summary>
       [Display(Name ="任務模板ID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? task_id { get; set; }

       /// <summary>
       ///表單code
       /// </summary>
       [Display(Name ="表單code")]
       [MaxLength(20)]
       [Column(TypeName="varchar(20)")]
       [Editable(true)]
       public string FormCode { get; set; }

       /// <summary>
       ///表單ID
       /// </summary>
       [Display(Name ="表單ID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? FormId { get; set; }

       /// <summary>
       ///表單值
       /// </summary>
       [Display(Name ="表單值")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? FormCollectionId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="start_date")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? start_date { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="end_date")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? end_date { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="order_no")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? order_no { get; set; }

       /// <summary>
       ///前置任務ID
       /// </summary>
       [Display(Name ="前置任務ID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? pre_task_id { get; set; }

       /// <summary>
       ///完成規則
       /// </summary>
       [Display(Name ="完成規則")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? rule_id { get; set; }

       /// <summary>
       ///是否EO/PO任務
       /// </summary>
       [Display(Name ="是否EO/PO任務")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       public string is_eo { get; set; }

       /// <summary>
       ///是否需要零品承辦參與審核
       /// </summary>
       [Display(Name ="是否需要零品承辦參與審核")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       public string is_part_handle { get; set; }

       /// <summary>
       ///是否允許刪除
       /// </summary>
       [Display(Name ="是否允許刪除")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       public string is_delete_able { get; set; }

       /// <summary>
       ///是否重點審計項目
       /// </summary>
       [Display(Name ="是否重點審計項目")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       public string is_audit_key { get; set; }

       /// <summary>
       ///承辦預警時間（天）
       /// </summary>
       [Display(Name ="承辦預警時間（天）")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? warn { get; set; }

       /// <summary>
       ///上級預警時間（天）
       /// </summary>
       [Display(Name ="上級預警時間（天）")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? warn_leader { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Creator")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string Creator { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? CreateID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateDate")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Modifier")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ModifyID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyDate")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Display(Name = "mapping_id")]
        [Column(TypeName = "uniqueidentifier")]
        [Editable(true)]
        public Guid? mapping_id { get; set; }


        /// <summary>
        /// eo任務所屬大日程id
        /// </summary>
        [Display(Name = "eo_gate_id")]
        [Column(TypeName = "uniqueidentifier")]
        [Editable(true)]
        public Guid? eo_gate_id { get; set; }
    }
}