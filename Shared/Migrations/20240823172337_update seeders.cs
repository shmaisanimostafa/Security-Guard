using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Security_Guard.Migrations
{
    /// <inheritdoc />
    public partial class updateseeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageURL", "PublishDate", "Title" },
                values: new object[] { "https://incubator.ucf.edu/wp-content/uploads/2023/07/artificial-intelligence-new-technology-science-futuristic-abstract-human-brain-ai-technology-cpu-central-processor-unit-chipset-big-data-machine-learning-cyber-mind-domination-generative-ai-scaled-1-1500x1000.jpg", new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4546), "Artificial Intilligence in CyberSecurity Integration" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "ImageURL", "PublishDate", "Title" },
                values: new object[] { "---\n__Advertisement :)__\n\n- __[pica](https://nodeca.github.io/pica/demo/)__ - high quality and fast image\n  resize in browser.\n- __[babelfish](https://github.com/nodeca/babelfish/)__ - developer friendly\n  i18n with plurals support and easy syntax.\n\nYou will like those projects!\n\n---\n\n# h1 Heading 8-)\n## h2 Heading\n### h3 Heading\n#### h4 Heading\n##### h5 Heading\n###### h6 Heading\n\n\n## Horizontal Rules\n\n___\n\n---\n\n***\n\n\n## Typographic replacements\n\nEnable typographer option to see result.\n\n(c) (C) (r) (R) (tm) (TM) (p) (P) +-\n\ntest.. test... test..... test?..... test!....\n\n!!!!!! ???? ,,  -- ---\n\n\"Smartypants, double quotes\" and 'single quotes'\n\n\n## Emphasis\n\n**This is bold text**\n\n__This is bold text__\n\n*This is italic text*\n\n_This is italic text_\n\n~~Strikethrough~~\n\n\n## Blockquotes\n\n\n> Blockquotes can also be nested...\n>> ...by using additional greater-than signs right next to each other...\n> > > ...or with spaces between arrows.\n\n\n## Lists\n\nUnordered\n\n+ Create a list by starting a line with `+`, `-`, or `*`\n+ Sub-lists are made by indenting 2 spaces:\n  - Marker character change forces new list start:\n    * Ac tristique libero volutpat at\n    + Facilisis in pretium nisl aliquet\n    - Nulla volutpat aliquam velit\n+ Very easy!\n\nOrdered\n\n1. Lorem ipsum dolor sit amet\n2. Consectetur adipiscing elit\n3. Integer molestie lorem at massa\n\n\n1. You can use sequential numbers...\n1. ...or keep all the numbers as `1.`\n\nStart numbering with offset:\n\n57. foo\n1. bar\n\n\n## Code\n\nInline `code`\n\nIndented code\n\n    // Some comments\n    line 1 of code\n    line 2 of code\n    line 3 of code\n\n\nBlock code \"fences\"\n\n```\nSample text here...\n```\n\nSyntax highlighting\n\n``` js\nvar foo = function (bar) {\n  return bar++;\n};\n\nconsole.log(foo(5));\n```\n\n## Tables\n\n| Option | Description |\n| ------ | ----------- |\n| data   | path to data files to supply the data that will be passed into templates. |\n| engine | engine to be used for processing templates. Handlebars is the default. |\n| ext    | extension to be used for dest files. |\n\nRight aligned columns\n\n| Option | Description |\n| ------:| -----------:|\n| data   | path to data files to supply the data that will be passed into templates. |\n| engine | engine to be used for processing templates. Handlebars is the default. |\n| ext    | extension to be used for dest files. |\n\n\n## Links\n\n[link text](http://dev.nodeca.com)\n\n[link with title](http://nodeca.github.io/pica/demo/ \"title text!\")\n\nAutoconverted link https://github.com/nodeca/pica (enable linkify to see)\n\n\n## Images\n\n![Minion](https://octodex.github.com/images/minion.png)\n![Stormtroopocat](https://octodex.github.com/images/stormtroopocat.jpg \"The Stormtroopocat\")\n\nLike links, Images also have a footnote style syntax\n\n![Alt text][id]\n\nWith a reference later in the document defining the URL location:\n\n[id]: https://octodex.github.com/images/dojocat.jpg  \"The Dojocat\"\n\n\n## Plugins\n\nThe killer feature of `markdown-it` is very effective support of\n[syntax plugins](https://www.npmjs.org/browse/keyword/markdown-it-plugin).\n\n\n### [Emojies](https://github.com/markdown-it/markdown-it-emoji)\n\n> Classic markup: :wink: :cry: :laughing: :yum:\n>\n> Shortcuts (emoticons): :-) :-( 8-) ;)\n\nsee [how to change output](https://github.com/markdown-it/markdown-it-emoji#change-output) with twemoji.\n\n\n### [Subscript](https://github.com/markdown-it/markdown-it-sub) / [Superscript](https://github.com/markdown-it/markdown-it-sup)\n\n- 19^th^\n- H~2~O\n\n\n### [\\<ins>](https://github.com/markdown-it/markdown-it-ins)\n\n++Inserted text++\n\n\n### [\\<mark>](https://github.com/markdown-it/markdown-it-mark)\n\n==Marked text==\n\n\n### [Footnotes](https://github.com/markdown-it/markdown-it-footnote)\n\nFootnote 1 link[^first].\n\nFootnote 2 link[^second].\n\nInline footnote^[Text of inline footnote] definition.\n\nDuplicated footnote reference[^second].\n\n[^first]: Footnote **can have markup**\n\n    and multiple paragraphs.\n\n[^second]: Footnote text.\n\n\n### [Definition lists](https://github.com/markdown-it/markdown-it-deflist)\n\nTerm 1\n\n:   Definition 1\nwith lazy continuation.\n\nTerm 2 with *inline markup*\n\n:   Definition 2\n\n        { some code, part of Definition 2 }\n\n    Third paragraph of definition 2.\n\n_Compact style:_\n\nTerm 1\n  ~ Definition 1\n\nTerm 2\n  ~ Definition 2a\n  ~ Definition 2b\n\n\n### [Abbreviations](https://github.com/markdown-it/markdown-it-abbr)\n\nThis is HTML abbreviation example.\n\nIt converts \"HTML\", but keep intact partial entries like \"xxxHTMLyyy\" and so on.\n\n*[HTML]: Hyper Text Markup Language\n\n### [Custom containers](https://github.com/markdown-it/markdown-it-container)\n\n::: warning\n*here be dragons*\n:::\n", "https://media.licdn.com/dms/image/v2/D4D12AQF6mW4EuB-99Q/article-cover_image-shrink_720_1280/article-cover_image-shrink_720_1280/0/1692951785182?e=1729728000&v=beta&t=6M80wcow6ABDFfa9fKJFkU6ddeLYd5RwVkJnNC44A7w", new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4560), "Makrdown Coding" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageURL", "PublishDate", "Title" },
                values: new object[] { "https://andrewlock.net/content/images/2018/02/asp.net-core-mvc.png", new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4566), "ASP.Net Core MVC Architicture" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageURL", "PublishDate", "Title" },
                values: new object[] { "https://miro.medium.com/v2/resize:fit:1400/1*dC6yYmAkwVq2UeF8HngSVw.jpeg", new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4572), "Open-Source Intelligence" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageURL", "PublishDate", "Title" },
                values: new object[] { "https://aag-it.com/wp-content/uploads/2022/10/shutterstock_1766138084-1024x768.jpg", new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4579), "Phishing" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageURL", "PublishDate", "Title" },
                values: new object[] { "https://www.searchenginejournal.com/wp-content/uploads/2020/08/an-introduction-to-natural-language-processing-with-python-for-seos-5f3519eeb8368.png", new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4586), "Natural Language Processing" });

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 0,
                column: "Time",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2024, 8, 23, 20, 23, 36, 874, DateTimeKind.Local).AddTicks(4467));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageURL", "PublishDate", "Title" },
                values: new object[] { "file://C:/Users/shmai/source/repos/Security%20Guard/wwwroot/Neighbors/Bitdefender.png", new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7226), "Bitdefender" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "ImageURL", "PublishDate", "Title" },
                values: new object[] { "The best for the best. The place where you can exercise your hiking and other sports.", "file://C:/Users/shmai/source/repos/Security_Guard/wwwroot/Neighbors/Dr.Web.png", new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7235), "Dr.Web" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageURL", "PublishDate", "Title" },
                values: new object[] { "https://c4.wallpaperflare.com/wallpaper/813/904/915/hotel-new-york-statue-of-liberty-in-las-vegas-nevada-usa-hd-desktop-wallpaper-1920%C3%971200-wallpaper-preview.jpg", new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7239), "eset" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageURL", "PublishDate", "Title" },
                values: new object[] { "https://wallpapershome.com/images/pages/ico_h/655.jpg", new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7242), "Kaspersky" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageURL", "PublishDate", "Title" },
                values: new object[] { "https://www.thesouthafrican.com/wp-content/uploads/2022/07/hotel-800x529.png", new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7245), "PhishTank" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageURL", "PublishDate", "Title" },
                values: new object[] { "https://wallpapercave.com/wp/wp12549190.jpg", new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7248), "VirusTotal" });

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "Files",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 0,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 0,
                column: "Time",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new DateTime(2024, 8, 23, 15, 51, 55, 610, DateTimeKind.Local).AddTicks(7126));
        }
    }
}
