using ICE2.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ICE2.Models
{
    public class ProjectTask
    {

        [Key]
        public int ProjectTaskId { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Description { get; set; }

        //foreign KEy
        public int ProjectId { get; set; }

        //Navigation Propert
        public Project? Project { get; set; }


    }

}