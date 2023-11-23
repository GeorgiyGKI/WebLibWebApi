using ServiceMVC.ServiceManager;

namespace WebLibMVC.Mapping
{
    public static class MappingMethods
    {
        public static byte[] FormFileToBytes(IFormFile file)
        {
            using (var memoryStream = new MemoryStream())
            {
                file.CopyTo(memoryStream);
                return memoryStream.ToArray();
            }
        }

        public static IFormFile ConvertBytesToFormFile(byte[] bytes)
        {
            // Вам нужно определить ContentType и FileName
            return new FormFile(new MemoryStream(bytes), 0, bytes.Length, "Image", "filename.jpg");
        }
    }
}
