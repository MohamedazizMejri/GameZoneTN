using GameZoneTN.Attributes;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GameZoneTN.ViewModels
{
    public class CreateGameFormViewModel : GameFormViewModel
    {
        [AllowedExtensions(FileSettings.AllowedExtensions), MaxFileSize(FileSettings.MaxFileSizeInBytes)]
        public IFormFile Cover { get; set; } = default!;
    }
}
