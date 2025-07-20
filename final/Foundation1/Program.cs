using System;

class Program
{
   static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Unboxing the Future", "TechieTom", 320);
        Video video2 = new Video("Makeup Transformation Magic", "BeautyByJen", 480);
        Video video3 = new Video("Epic Fails Compilation", "LaughOutLoud", 210);
        Video video4 = new Video("Guitar Cover: Thunderstruck", "RockinRay", 300);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "Awesome review!"));
        video1.AddComment(new Comment("Bob", "I want that gadget now."));
        video1.AddComment(new Comment("Charlie", "Very detailed, thanks!"));

        // Add comments to video2
        video2.AddComment(new Comment("Diana", "Love the look!"));
        video2.AddComment(new Comment("Eva", "You make it look so easy!"));
        video2.AddComment(new Comment("Frank", "Great tutorial."));

        // Add comments to video3
        video3.AddComment(new Comment("George", "I laughed so hard!"));
        video3.AddComment(new Comment("Hannah", "Poor guy at 2:10 😅"));
        video3.AddComment(new Comment("Ian", "These never get old."));

        // Add comments to video4
        video4.AddComment(new Comment("Jake", "Rock on!"));
        video4.AddComment(new Comment("Karen", "You nailed the solo!"));
        video4.AddComment(new Comment("Liam", "My favorite cover ever."));

        // Add videos to a list
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Display each video's details
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}