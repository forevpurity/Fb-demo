namespace Fb_demo.Firebase
{
    public interface IFirebaseImageService
    {
        Task<FirebaseImageResponse> UploadBase64Image(String base64Image);
        Task DeleteImage(string imageUrl);
    }
}
