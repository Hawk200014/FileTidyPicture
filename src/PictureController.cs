using FileTidyBase;
using FileTidyPicture.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTidyPicture
{
    public class PictureController : BaseController<PictureModel>
    {
        public PictureController(string directoryPath) : base(directoryPath, new string[] { ".bmp", ".webp", ".jpeg", ".png" })
        {

        }
    }
}
