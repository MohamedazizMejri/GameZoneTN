namespace GameZoneTN.Services
{
    public interface ICategoriesService
    {
        IEnumerable<SelectListItem> GetSelectList();
    }
}

