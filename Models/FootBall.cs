using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FootBallMatchs.Models
{
    public class FootBall
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required (ErrorMessage = "ID must be Declared")]
        [Range(1, long.MaxValue, ErrorMessage = "MatchID cannot be zero")]
        public int MatchID { get; set; }

        [Required(ErrorMessage = "TeamName1 must be specified")]
        [StringLength(byte.MaxValue, MinimumLength = 2, ErrorMessage = "Minimum length must be 2")]
        public string TeamName1 { get; set; }

        [Required(ErrorMessage = "TeamName2 must be specified")]
        public string TeamName2 { get; set; }
        
        [Required(ErrorMessage = "It was Based on Status")]
        public string Status { get; set; }
        [Required(ErrorMessage = "It was Based on Status")]
        public string WinningTeam { get; set; }
        [Required(ErrorMessage = "Points Must be specified")]
        [Range(500, long.MaxValue, ErrorMessage = "Points must be specified")]
        public double Points { get; set; }
    }
}