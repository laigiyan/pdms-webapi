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
    [Entity(TableCnName = "成本編列",TableName = "view_cmc_project_cost_maintain",DBServer = "SysDbContext")]
    public partial class view_cmc_project_cost_maintain:SysEntity
    {
        /// <summary>
       ///epl_id
       /// </summary>
       [Key]
       [Display(Name ="epl_id")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public Guid epl_id { get; set; }

       /// <summary>
       ///大專案ID
       /// </summary>
       [Display(Name ="大專案ID")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? project_id { get; set; }

       /// <summary>
       ///子專案計劃模板
       /// </summary>
       [Display(Name ="子專案計劃模板")]
       [Column(TypeName="uniqueidentifier")]
       [Editable(true)]
       public Guid? main_plan_id { get; set; }

       /// <summary>
       ///epl來源
       /// </summary>
       [Display(Name ="epl來源")]
       [MaxLength(2)]
       [Column(TypeName="varchar(2)")]
       [Editable(true)]
       public string epl_source { get; set; }

       /// <summary>
       ///epl_phase
       /// </summary>
       [Display(Name ="epl_phase")]
       [MaxLength(2)]
       [Column(TypeName="varchar(2)")]
       [Editable(true)]
       public string epl_phase { get; set; }

       /// <summary>
       ///上傳時間
       /// </summary>
       [Display(Name ="上傳時間")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? epl_import_date { get; set; }

       /// <summary>
       ///部門-UPGID
       /// </summary>
       [Display(Name ="部門-UPGID")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string upg_id { get; set; }

       /// <summary>
       ///level
       /// </summary>
       [Display(Name ="level")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? level { get; set; }

       /// <summary>
       ///零件號
       /// </summary>
       [Display(Name ="零件號")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string part_no { get; set; }

       /// <summary>
       ///零件名稱
       /// </summary>
       [Display(Name ="零件名稱")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string part_name { get; set; }

       /// <summary>
       ///廠商代碼
       /// </summary>
       [Display(Name ="廠商代碼")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string company_code { get; set; }

       /// <summary>
       ///KD類型
       /// </summary>
       [Display(Name ="KD類型")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string kd_type { get; set; }

       /// <summary>
       ///部門代碼
       /// </summary>
       [Display(Name ="部門代碼")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string org_code { get; set; }

       /// <summary>
       ///變動部門
       /// </summary>
       [Display(Name ="變動部門")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string new_org_code { get; set; }

       /// <summary>
       ///組別代碼
       /// </summary>
       [Display(Name ="組別代碼")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string group_code { get; set; }

       /// <summary>
       ///開發承辦
       /// </summary>
       [Display(Name ="開發承辦")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? dev_taker_id { get; set; }

       /// <summary>
       ///零品承辦
       /// </summary>
       [Display(Name ="零品承辦")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? part_taker_id { get; set; }

       /// <summary>
       ///開發費
       /// </summary>
       [Display(Name ="開發費")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       [Editable(true)]
       public decimal? fs_1 { get; set; }

       /// <summary>
       ///模具費
       /// </summary>
       [Display(Name ="模具費")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       [Editable(true)]
       public decimal? fs_2 { get; set; }

       /// <summary>
       ///設變費
       /// </summary>
       [Display(Name ="設變費")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       [Editable(true)]
       public decimal? fs_3 { get; set; }

       /// <summary>
       ///估價說明
       /// </summary>
       [Display(Name ="估價說明")]
       [MaxLength(4000)]
       [Column(TypeName="nvarchar(4000)")]
       [Editable(true)]
       public string fs_remark { get; set; }

       /// <summary>
       ///定版狀態
       /// </summary>
       [Display(Name ="定版狀態")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       public string Final_version_status { get; set; }

       /// <summary>
       ///成本編列審核狀態
       /// </summary>
       [Display(Name ="成本編列審核狀態")]
       [MaxLength(2)]
       [Column(TypeName="varchar(2)")]
       [Editable(true)]
       public string fs_approve_status { get; set; }

       /// <summary>
       ///主工作計劃審核狀態
       /// </summary>
       [Display(Name ="主工作計劃審核狀態")]
       [MaxLength(2)]
       [Column(TypeName="varchar(2)")]
       [Editable(true)]
       public string task_define_approve_status { get; set; }

       /// <summary>
       ///部門變更審核狀態
       /// </summary>
       [Display(Name ="部門變更審核狀態")]
       [MaxLength(2)]
       [Column(TypeName="varchar(2)")]
       [Editable(true)]
       public string org_change_approve_status { get; set; }

       /// <summary>
       ///gate_type
       /// </summary>
       [Display(Name ="gate_type")]
       [MaxLength(20)]
       [Column(TypeName="varchar(20)")]
       [Editable(true)]
       public string gate_type { get; set; }

       /// <summary>
       ///是否EO/PO任務
       /// </summary>
       [Display(Name ="是否EO/PO任務")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       public string is_eo { get; set; }

       /// <summary>
       ///原件號
       /// </summary>
       [Display(Name ="原件號")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string original_part_no { get; set; }

       /// <summary>
       ///CreateID
       /// </summary>
       [Display(Name ="CreateID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? CreateID { get; set; }

       /// <summary>
       ///Creator
       /// </summary>
       [Display(Name ="Creator")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string Creator { get; set; }

       /// <summary>
       ///CreateDate
       /// </summary>
       [Display(Name ="CreateDate")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///ModifyID
       /// </summary>
       [Display(Name ="ModifyID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ModifyID { get; set; }

       /// <summary>
       ///Modifier
       /// </summary>
       [Display(Name ="Modifier")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///ModifyDate
       /// </summary>
       [Display(Name ="ModifyDate")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///del_flag
       /// </summary>
       [Display(Name ="del_flag")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       public string del_flag { get; set; }

       /// <summary>
       ///幣別
       /// </summary>
       [Display(Name ="幣別")]
       [MaxLength(10)]
       [Column(TypeName="varchar(10)")]
       [Editable(true)]
       public string currency { get; set; }

       /// <summary>
       ///提交狀態
       /// </summary>
       [Display(Name ="提交狀態")]
       [MaxLength(2)]
       [Column(TypeName="varchar(2)")]
       [Editable(true)]
       public string submit_status { get; set; }

       /// <summary>
       ///狀態
       /// </summary>
       [Display(Name ="狀態")]
       [MaxLength(20)]
       [Column(TypeName="varchar(20)")]
       [Editable(true)]
       public string action_type { get; set; }

       /// <summary>
       ///版本
       /// </summary>
       [Display(Name ="版本")]
       [Column(TypeName= "varchar(20)")]
       [Editable(true)]
       public string? version { get; set; }


        /// <summary>
        ///EO费率
        /// </summary>
        [Display(Name = "eo费率")]
        [DisplayFormat(DataFormatString = "10,2")]
        [Column(TypeName = "decimal")]
        [Editable(true)]
        public decimal? eo_fee { get; set; }
    }
}