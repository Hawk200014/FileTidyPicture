using FileTidyBase.Models;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace FileTidyPicture.Models
{

    public class PictureModel : FileBaseModel
    {
        private int _width = 0;
        private int _height = 0;
        public int Width
        {
            get { return _width; }
        }

        public int Height
        {
            get { return _height; }
        }

        public PictureModel(string filePath) : base(filePath)
        {
            
        }

        [SupportedOSPlatform("windows")]
        private void GetPictureDimensions()
        {
            Image i = Image.FromStream(File.OpenRead(this.FilePath));
            _width = i.Width;
            _height = i.Height;
        }

        public async Task GetPictureInfo()
        {
            if(!File.Exists(this.FilePath))
                throw new Exception("File does not exist");

            if(System.Runtime.InteropServices.RuntimeInformation
                                               .IsOSPlatform(OSPlatform.Windows))
                GetPictureDimensions();
            await base.GetFileInfo();
        }
    }
}
