Post post1 = new Post();
System.Console.WriteLine(post1.Publish());
post1.Title = "Salom";
post1.Description = "salom ba hama";
System.Console.WriteLine( "number of likes " + post1.Likecount);
post1.Comment("Dubai");
post1.Comment("Duwanbe");

Post post2 = new Post();

post2.Title = "Salom";
post2.Description = "salom ba hama";
System.Console.WriteLine( "number of likes " + post1.Likecount);
post2.Comment("Dubai");
post2.Comment("Duwanbe");
Post post3 = new Post();
post3.Title = "Salom";
post1.Description = "salom ba hama";
System.Console.WriteLine( "number of likes " + post1.Likecount);
post3.Comment("Dubai");
post3.Comment("Duwanbe");

Post post4 = new Post();

post4.Title = "Salom";
post4.Description = "salom ba hama";
System.Console.WriteLine( "number of likes " + post1.Likecount);
post4.Comment("Dubai");
post4.Comment("Duwanbe");








System.Console.WriteLine("Comments : ");
foreach (var icon in post1.Comments)
{
    System.Console.WriteLine(icon);
}



class Post
{
    public string Title;
    public int Likecount = 1;
    public string Description;
    public List<string> Comments = new List<string>();
    public bool IsPublished;

    public string Publish()
    {
        return "The post is published.";
         IsPublished = true;
    }

    public void Like()
    {
      Likecount ++;
    }

    public void Comment(string message)
    {
        Comments.Add(message);
    }

    
}


