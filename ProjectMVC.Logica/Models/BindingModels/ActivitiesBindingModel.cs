using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Logica.Models.BindingModels
{
    public class ActivitiesCreateBindingModel
    {
        [Required(ErrorMessage = "The field name is required")]
        [Display(Name = "Name")]
        public string Name { get; set; }
    }

    public class ActivitiesEditBindingModel
    {
        [Required(ErrorMessage = "The field Id is required")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field name is required")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field Active is required")]
        [Display(Name = "Active")]
        public bool Active { get; set; }


    }
}
