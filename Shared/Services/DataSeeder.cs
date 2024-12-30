using Microsoft.EntityFrameworkCore;
//using Security_Guard.Models; // Make sure this namespace includes Tag and ArticleTag models
//using Security_Guard_API.Models;
//using File = Security_Guard.Models.File; // Include your other related models
using File = Shared.Models.File;
using Shared.Models;
public static class DataSeeder
{
    public static void SeedData(this ModelBuilder modelBuilder)
    {
        SeedFiles(modelBuilder);
        SeedLinks(modelBuilder);
        SeedMessages(modelBuilder);
        SeedArticles(modelBuilder); // Ensure this is called to seed Articles
        SeedTags(modelBuilder); // Add this to seed Tags
        SeedArticleTags(modelBuilder); // Add this to seed ArticleTags
    }

    private static void SeedMessages(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Message>().HasData(
            new Message
            {
                Id = 0,
                Text = "Hello",
                Sender = "Mostafa",
                IsAi = false,
                Time = DateTime.Now
            },
            new Message
            {
                Id = 1,
                Text = "Hi",
                Sender = "AI",
                IsAi = true,
                Time = DateTime.Now
            },
            new Message
            {
                Id = 2,
                Text = "How are you?",
                Sender = "Mostafa",
                IsAi = false,
                Time = DateTime.Now
            },
            new Message
            {
                Id = 3,
                Text = "I'm fine",
                Sender = "AI",
                IsAi = true,
                Time = DateTime.Now
            },
            new Message
            {
                Id = 4,
                Text = "Good",
                Sender = "Mostafa",
                IsAi = false,
                Time = DateTime.Now
            },
            new Message
            {
                Id = 5,
                Text = "Bye",
                Sender = "AI",
                IsAi = true,
                Time = DateTime.Now
            },
            new Message
            {
                Id = 6,
                Text = "Bye",
                Sender = "Mostafa",
                IsAi = false,
                Time = DateTime.Now
            },
            new Message
            {
                Id = 7,
                Text = "Goodbye",
                Sender = "AI",
                IsAi = true,
                Time = DateTime.Now
            }
        );
    }

    private static void SeedFiles(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<File>().HasData(
            new File
            {
                Id = 0,
                UserName = "Mostafa",
                FileName = "Virus.pdf",
                DateTime = DateTime.Now,
                URL = "www.virus.com",
                Status = "danger"
            },
            new File
            {
                Id = 1,
                UserName = "Mostafa",
                FileName = "Malware.pdf",
                DateTime = DateTime.Now,
                URL = "www.malware.ar",
                Status = "danger"
            },
            new File
            {
                Id = 2,
                UserName = "Mostafa",
                FileName = "potato.pdf",
                DateTime = DateTime.Now,
                URL = "www.potato.me",
                Status = "danger"
            },
            new File
            {
                Id = 3,
                UserName = "Mostafa",
                FileName = "Virus.pdf",
                DateTime = DateTime.Now,
                URL = "www.virus.com",
                Status = "safe"
            },
            new File
            {
                Id = 4,
                UserName = "Mostafa",
                FileName = "Malware.pdf",
                DateTime = DateTime.Now,
                URL = "www.malware.ar",
                Status = "safe"
            },
            new File
            {
                Id = 5,
                UserName = "Mostafa",
                FileName = "potato.pdf",
                DateTime = DateTime.Now,
                URL = "www.potato.me",
                Status = "ambiguous"
            }
        );
    }

    private static void SeedLinks(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Link>().HasData(
            new Link
            {
                Id = 0,
                UserName = "Mostafa",
                DateTime = DateTime.Now,
                URL = "www.pdf.com.lb.mu.edu",
                Status = "danger"
            },
            new Link
            {
                Id = 1,
                UserName = "Mostafa",
                DateTime = DateTime.Now,
                URL = "www.trojans.ar",
                Status = "safe"
            },
            new Link
            {
                Id = 2,
                UserName = "Mostafa",
                DateTime = DateTime.Now,
                URL = "www.malosd.me",
                Status = "ambiguous"
            }
        );
    }

    private static void SeedArticles(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Article>().HasData(
            new Article
            {
                Id = 1,
                Rating = 3,
                AuthorId = "283f0143-db7d-4602-986e-3797bcba4f69",
                Content = "Do you want to see the sea? This your best Hotel",
                Title = "Artificial Intilligence in CyberSecurity Integration",
                SourceURL = "https://www.bitdefender.com/",
                ImageURL = "https://incubator.ucf.edu/wp-content/uploads/2023/07/artificial-intelligence-new-technology-science-futuristic-abstract-human-brain-ai-technology-cpu-central-processor-unit-chipset-big-data-machine-learning-cyber-mind-domination-generative-ai-scaled-1-1500x1000.jpg"
            },
            new Article
            {
                Id = 2,
                Rating = 5,
                AuthorId = "283f0143-db7d-4602-986e-3797bcba4f69",
                Content = "---\n__Advertisement :)__\n\n- __[pica](https://nodeca.github.io/pica/demo/)__ - high quality and fast image\n  resize in browser.\n- __[babelfish](https://github.com/nodeca/babelfish/)__ - developer friendly\n  i18n with plurals support and easy syntax.\n\nYou will like those projects!\n\n---\n\n# h1 Heading 8-)\n## h2 Heading\n### h3 Heading\n#### h4 Heading\n##### h5 Heading\n###### h6 Heading\n\n\n## Horizontal Rules\n\n___\n\n---\n\n***\n\n\n## Typographic replacements\n\nEnable typographer option to see result.\n\n(c) (C) (r) (R) (tm) (TM) (p) (P) +-\n\ntest.. test... test..... test?..... test!....\n\n!!!!!! ???? ,,  -- ---\n\n\"Smartypants, double quotes\" and 'single quotes'\n\n\n## Emphasis\n\n**This is bold text**\n\n__This is bold text__\n\n*This is italic text*\n\n_This is italic text_\n\n~~Strikethrough~~\n\n\n## Blockquotes\n\n\n> Blockquotes can also be nested...\n>> ...by using additional greater-than signs right next to each other...\n> > > ...or with spaces between arrows.\n\n\n## Lists\n\nUnordered\n\n+ Create a list by starting a line with `+`, `-`, or `*`\n+ Sub-lists are made by indenting 2 spaces:\n  - Marker character change forces new list start:\n    * Ac tristique libero volutpat at\n    + Facilisis in pretium nisl aliquet\n    - Nulla volutpat aliquam velit\n+ Very easy!\n\nOrdered\n\n1. Lorem ipsum dolor sit amet\n2. Consectetur adipiscing elit\n3. Integer molestie lorem at massa\n\n\n1. You can use sequential numbers...\n1. ...or keep all the numbers as `1.`\n\nStart numbering with offset:\n\n57. foo\n1. bar\n\n\n## Code\n\nInline `code`\n\nIndented code\n\n    // Some comments\n    line 1 of code\n    line 2 of code\n    line 3 of code\n\n\nBlock code \"fences\"\n\n```\nSample text here...\n```\n\nSyntax highlighting\n\n``` js\nvar foo = function (bar) {\n  return bar++;\n};\n\nconsole.log(foo(5));\n```\n\n## Tables\n\n| Option | Description |\n| ------ | ----------- |\n| data   | path to data files to supply the data that will be passed into templates. |\n| engine | engine to be used for processing templates. Handlebars is the default. |\n| ext    | extension to be used for dest files. |\n\nRight aligned columns\n\n| Option | Description |\n| ------:| -----------:|\n| data   | path to data files to supply the data that will be passed into templates. |\n| engine | engine to be used for processing templates. Handlebars is the default. |\n| ext    | extension to be used for dest files. |\n\n\n## Links\n\n[link text](http://dev.nodeca.com)\n\n[link with title](http://nodeca.github.io/pica/demo/ \"title text!\")\n\nAutoconverted link https://github.com/nodeca/pica (enable linkify to see)\n\n\n## Images\n\n![Minion](https://octodex.github.com/images/minion.png)\n![Stormtroopocat](https://octodex.github.com/images/stormtroopocat.jpg \"The Stormtroopocat\")\n\nLike links, Images also have a footnote style syntax\n\n![Alt text][id]\n\nWith a reference later in the document defining the URL location:\n\n[id]: https://octodex.github.com/images/dojocat.jpg  \"The Dojocat\"\n\n\n## Plugins\n\nThe killer feature of `markdown-it` is very effective support of\n[syntax plugins](https://www.npmjs.org/browse/keyword/markdown-it-plugin).\n\n\n### [Emojies](https://github.com/markdown-it/markdown-it-emoji)\n\n> Classic markup: :wink: :cry: :laughing: :yum:\n>\n> Shortcuts (emoticons): :-) :-( 8-) ;)\n\nsee [how to change output](https://github.com/markdown-it/markdown-it-emoji#change-output) with twemoji.\n\n\n### [Subscript](https://github.com/markdown-it/markdown-it-sub) / [Superscript](https://github.com/markdown-it/markdown-it-sup)\n\n- 19^th^\n- H~2~O\n\n\n### [\\<ins>](https://github.com/markdown-it/markdown-it-ins)\n\n++Inserted text++\n\n\n### [\\<mark>](https://github.com/markdown-it/markdown-it-mark)\n\n==Marked text==\n\n\n### [Footnotes](https://github.com/markdown-it/markdown-it-footnote)\n\nFootnote 1 link[^first].\n\nFootnote 2 link[^second].\n\nInline footnote^[Text of inline footnote] definition.\n\nDuplicated footnote reference[^second].\n\n[^first]: Footnote **can have markup**\n\n    and multiple paragraphs.\n\n[^second]: Footnote text.\n\n\n### [Definition lists](https://github.com/markdown-it/markdown-it-deflist)\n\nTerm 1\n\n:   Definition 1\nwith lazy continuation.\n\nTerm 2 with *inline markup*\n\n:   Definition 2\n\n        { some code, part of Definition 2 }\n\n    Third paragraph of definition 2.\n\n_Compact style:_\n\nTerm 1\n  ~ Definition 1\n\nTerm 2\n  ~ Definition 2a\n  ~ Definition 2b\n\n\n### [Abbreviations](https://github.com/markdown-it/markdown-it-abbr)\n\nThis is HTML abbreviation example.\n\nIt converts \"HTML\", but keep intact partial entries like \"xxxHTMLyyy\" and so on.\n\n*[HTML]: Hyper Text Markup Language\n\n### [Custom containers](https://github.com/markdown-it/markdown-it-container)\n\n::: warning\n*here be dragons*\n:::\n",
                Title = "Makrdown Coding",
                SourceURL = "https://www.drweb.com/",
                ImageURL = "https://media.licdn.com/dms/image/v2/D4D12AQF6mW4EuB-99Q/article-cover_image-shrink_720_1280/article-cover_image-shrink_720_1280/0/1692951785182?e=1729728000&v=beta&t=6M80wcow6ABDFfa9fKJFkU6ddeLYd5RwVkJnNC44A7w"
            },
            new Article
            {
                Id = 3,
                Rating = 4,
                AuthorId = "283f0143-db7d-4602-986e-3797bcba4f69",
                Content = "Sleep for cheap. Cheapest Hotel you may ever found",
                Title = "ASP.Net Core MVC Architicture",
                SourceURL = "https://www.eset.com/",
                ImageURL = "https://andrewlock.net/content/images/2018/02/asp.net-core-mvc.png"
            },
            new Article
            {
                Id = 4,
                Rating = 3,
                AuthorId = "283f0143-db7d-4602-986e-3797bcba4f69",
                Content = "Do you want to see the sea? This your best Hotel",
                Title = "Open-Source Intelligence",
                SourceURL = "https://me-en.kaspersky.com/",
                ImageURL = "https://miro.medium.com/v2/resize:fit:1400/1*dC6yYmAkwVq2UeF8HngSVw.jpeg"
            },
            new Article
            {
                Id = 5,
                AuthorId = "283f0143-db7d-4602-986e-3797bcba4f69",
                Rating = 1,
                Content = "The best for the best. The place where you can exercise your hiking and other sports.",
                Title = "Phishing",
                SourceURL = "https://phishtank.org/",
                ImageURL = "https://aag-it.com/wp-content/uploads/2022/10/shutterstock_1766138084-1024x768.jpg"
            },
            new Article
            {
                Id = 6,
                Rating = 2,
                AuthorId = "283f0143-db7d-4602-986e-3797bcba4f69",
                Content = "Sleep for cheap. Cheapest Hotel you may ever found",
                Title = "Natural Language Processing",
                SourceURL = "https://www.virustotal.com/gui/home/upload",
                ImageURL = "https://www.searchenginejournal.com/wp-content/uploads/2020/08/an-introduction-to-natural-language-processing-with-python-for-seos-5f3519eeb8368.png"
            }
        );
    }

    private static void SeedTags(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tag>().HasData(
            new Tag { Id = 1, Name = "Security" },
            new Tag { Id = 2, Name = "Antivirus" },
            new Tag { Id = 3, Name = "Privacy" }
        );
    }

    private static void SeedArticleTags(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ArticleTag>().HasData(
            new ArticleTag { ArticleId = 1, TagId = 1 },
            new ArticleTag { ArticleId = 1, TagId = 2 },
            new ArticleTag { ArticleId = 2, TagId = 2 },
            new ArticleTag { ArticleId = 3, TagId = 3 },
            new ArticleTag { ArticleId = 4, TagId = 1 },
            new ArticleTag { ArticleId = 5, TagId = 1 },
            new ArticleTag { ArticleId = 6, TagId = 2 }
        );
    }
}
