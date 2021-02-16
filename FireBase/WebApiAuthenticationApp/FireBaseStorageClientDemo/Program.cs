using Firebase.Auth;
using Firebase.Storage;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace FireBaseStorage.ClientApp
{

    // see the demo here:
    // https://github.com/step-up-labs/firebase-storage-dotnet/blob/master/samples/SimpleConsole/SimpleConsole/Program.cs

    enum CurrentTask
    {
        UPLOAD = 0,
        DOWNLOAD,
        DELETE
    }
    internal class Program
    {
        private static string ApiKey = "AIzaSyA6_F-DM69QG4holaNBd95EYVrV_qiXZg4";
        private static string Bucket = "fir-cookbook-a1787.appspot.com";
        private static string AuthEmail = "vincent.tene@gmail.com";
        private static string AuthPassword = "123oaotkvdp#*";
        private static CurrentTask request = CurrentTask.UPLOAD;
        private static FirebaseStorageTask task;

        private static void Main(string[] args)
        {
            request = CurrentTask.UPLOAD;
            Run().Wait();

            Console.Read();
        }

        private static async Task Run()
        {
            // FirebaseStorage.Put method accepts any type of stream.
            // var stream = new MemoryStream(Encoding.ASCII.GetBytes("Hello world!"));
             var stream = File.Open(@"C:\Users\Tene\Downloads\FIREBASE_COOKBOOK.pdf", FileMode.Open);

            // of course you can login using other method, not just email+password
            var auth = new FirebaseAuthProvider(new FirebaseConfig(ApiKey));
            var authLink = await auth.SignInWithEmailAndPasswordAsync(AuthEmail, AuthPassword);

            // var authLink2 = await auth.SignInWithOAuthAsync(FirebaseAuthType.Google, authLink.FirebaseToken);

           // you can use CancellationTokenSource to cancel the upload midway
           var cancellation = new CancellationTokenSource();

            var options =  
                new FirebaseStorageOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(authLink.FirebaseToken),
                    ThrowOnCancel = true // when you cancel the upload, exception is thrown. By default no exception is thrown
                };

            if(request == CurrentTask.UPLOAD)
            {
                task = new FirebaseStorage(
                    Bucket, options)
                    .Child("receipts")
                    .Child("FIREBASE_COOKBOOK2.pdf")
                    .PutAsync(stream, cancellation.Token);

                task.Progress.ProgressChanged += (s, e) => Console.WriteLine($"Progress: {e.Percentage} %");
                Console.WriteLine("Download link:\n" + await task);

            }
            else if(request == CurrentTask.DOWNLOAD)
            {
                var result = await new FirebaseStorage(
                    Bucket, options)
                    .Child("receipts")
                    .Child("FIREBASE_COOKBOOK2.pdf")
                    .GetDownloadUrlAsync();

                Console.WriteLine(result);
            }
            else if (request == CurrentTask.DELETE)
            {
                 await new FirebaseStorage(
                    Bucket, options)
                    .Child("receipts")
                    .Child("FIREBASE_COOKBOOK2.pdf")
                    .DeleteAsync(); 
            }
             
        }

    }
}

