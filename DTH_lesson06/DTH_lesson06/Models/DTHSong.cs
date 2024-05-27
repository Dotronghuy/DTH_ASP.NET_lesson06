using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DTH_lesson06.Models
{
    public class DTHSong
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "ĐTH:Hãy nhập trường này!!!")]
        public string dthTitle { get; set; }
        [Required(ErrorMessage = "ĐTH: Hãy nhập tên tác giá ")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "ĐTH: Độ dài trong khoảng [2-20]")]
        public string dthAuthor { get; set; }
        [Required(ErrorMessage = "ĐTH: Hãy nhập năm nghệ sĩ")]
        public string dthArtist { get; set; }
        [Required(ErrorMessage = "ĐTH: Hãy nhập năm xuất bản")]
        [RegularExpression(@"[0-9]{4}",ErrorMessage = "ĐTH: Hãy nhập 4 ký tự từ số")]
        [Range(1900,2016,ErrorMessage = "ĐTH: Hãy nhập giá trị trong khoảng [1900-2016]")]
        public int dthYearRelease { get; set; }
        





    }

}