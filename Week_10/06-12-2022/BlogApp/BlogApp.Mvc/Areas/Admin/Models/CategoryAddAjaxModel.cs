using BlogApp.Entities.Dtos;

namespace BlogApp.Mvc.Areas.Admin.Models
{
    public class CategoryUpdateAjaxViewModel
    {
        internal string CategoryUpdatePartial;

        public CategoryAddDto CategoryUpdateDto { get; set; }
        public string CategoryAddPartial { get; set; }
        public CategoryDto CategoryDto { get; set; }
    }
}
