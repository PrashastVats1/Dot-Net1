using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    public class PhotoBookSol
    {
        public static void Main4(string[] args)
        {
            PhotoBook Alb1 = new PhotoBook();
            Console.WriteLine(Alb1.GetNumberPages());

            PhotoBook Alb2 = new PhotoBook(24);
            Console.WriteLine(Alb2.GetNumberPages());

            BigPhotoBook BigPhotoAlb1 = new BigPhotoBook();
            Console.WriteLine(BigPhotoAlb1.GetNumberPages());
        }
    }

    public class PhotoBook
    {
        protected int numPages;

        public PhotoBook()
        {
            numPages = 16;
        }

        public PhotoBook(int numPages)
        {
            this.numPages = numPages;
        }

        public int GetNumberPages()
        {
            return numPages;
        }
    }

    public class BigPhotoBook : PhotoBook
    {
        public BigPhotoBook()
        {
            numPages = 64;
        }
    }

}
