using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Manager
{
    public partial class Books : UserControl
    { 
        DataTable tableOfBooks = new DataTable("Books");
        public Books()
        { 
            InitializeComponent();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            ColumnsForDataGrideView1();
            PreDefinedRowsForDataGridView1();
            
            //Database._Instance.DatabaseOfBooks.Rows.Add("100", "Le Miserable", "Victor Hugo", "Fiction", "09/26/2022", "2016", "On-Shelf");

            //tableOfBooks.Rows.Add("100", "Le Miserable", "Victor Hugo", "Fiction", "09/26/2022", "2016", "On-Shelf");
            //tableOfBooks.Rows.Add("100", "Le Miserable Le Miserable Le Miserable Le Miserable", "Victor Hugo", "Fiction", "09/26/2022", "2016", "On-Shelf");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ColumnsForDataGrideView1()
        {
            Database._Instance.DatabaseOfBooks.Columns.Add("Dewey Decimal System", Type.GetType("System.Int32"));
            Database._Instance.DatabaseOfBooks.Columns.Add("Title", Type.GetType("System.String"));
            Database._Instance.DatabaseOfBooks.Columns.Add("Aurhor", Type.GetType("System.String"));
            Database._Instance.DatabaseOfBooks.Columns.Add("Category", Type.GetType("System.String"));
            Database._Instance.DatabaseOfBooks.Columns.Add("Year of Publication", Type.GetType("System.String"));
            Database._Instance.DatabaseOfBooks.Columns.Add("Date Added", Type.GetType("System.String")); 
            Database._Instance.DatabaseOfBooks.Columns.Add("Availability", Type.GetType("System.String"));

            dataGridView1.DataSource = Database._Instance.DatabaseOfBooks;

            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 140;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 150;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void PreDefinedRowsForDataGridView1()
        {
            /* <========================================================> */

            // 000 | Generalities
            Database._Instance.DatabaseOfBooks.Rows.Add("000", "Articulating Design Decisions: Communicate with Stakeholders, Keep Your Sanity, and Deliver the Best User Experience ", "Tom Greever", "Generalities", "2015", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("010", "UX Strategy: How to Devise Innovative Digital Products that People Want", "Jaime Levy", "Generalities", "2014", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("020", "Casa-Grande e Senzala", "Gilberto Freyre", "Generalities", "1933", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("030", "10,000 Answers: The Ultimate Trivia Encyclopedia", "Stanley Newman , Hal Fittipaldi", "Generalities", "2001", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("040", "Time: The Illustrated History of the World's Most Influential Magazine", "Norberto Angelleti", "Generalities", "2010", "N/A", "On-Shelf");
            
            Database._Instance.DatabaseOfBooks.Rows.Add("050", "Personal History: A Memoir", "Katherine Graham", "Generalities", "1997", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("060", "The Tender Bar : A Memoir", "J.R. Moehringer", "Generalities", "2005", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("070", "Unfreedom of the Press(Kindle Edition)", "Mark R. Levin", "Generalities", "2019", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("080", "The Smear: How the Secret Art of Character Assassination Controls What You Think, What You Read, and How You Vote", "Sharyl Attkinson", "Generalities", "2017", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("090", "Elizabeth Finch", "Julian Barnes", "Generalities", "2022", "N/A", "On-Shelf");

            /* <========================================================> */

            // 100 | Philosophy and Psychology
            Database._Instance.DatabaseOfBooks.Rows.Add("100", "The Republic", "Plato", "Philosophy and Psychology", "N/A", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("110", "Beyond Good and Evil", "Friedrich Nietzsche", "Philosophy and Psychology", "1886", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("120", "Being and Time", "Martin Heidegger", "Philosophy and Psychology", "1927", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("130", "The Interpretation of Dreams", "Sigmund Freud", "Philosophy and Psychology", "1899", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("140", "Critique of Pure Reason", "Immanuel Kant", "Philosophy and Psychology", "1781", "N/A", "On-Shelf");

            Database._Instance.DatabaseOfBooks.Rows.Add("150", "The Prince", "Niccolò Machiavelli", "Philosophy and Psychology", "1532", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("160", "Thus Spoke Zarathustra", "Friedrich Nietzsche", "Philosophy and Psychology", "1883", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("170", "The Varieties of Religious Experience", "William James", "Philosophy and Psychology", "1902", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("180", "Discipline and Punish", "Michel Foucault", "Philosophy and Psychology", "1975", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("190", "The Second Sex", "Simone de Beauvoir", "Philosophy and Psychology", "1949", "N/A", "On-Shelf");

            /* <========================================================> */

            // 200 | Religion
            Database._Instance.DatabaseOfBooks.Rows.Add("200", "The Bhagavad Gita", "N/A", "Religion", "N/A", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("210", "The Quran", "N/A", "Religion", "N/A", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("220", "The Tibetan Book of the Dead", "Padmasambhava", "Religion", "N/A", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("230", "Confessions", "Saint Augustine", "Religion", "N/A", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("240", "The Tao Te Ching", "Laozi", "Religion", "N/A", "N/A", "On-Shelf");

            Database._Instance.DatabaseOfBooks.Rows.Add("250", "The Book of Mormon", "Joseph Smith", "Religion", "1830", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("260", "The Essential Rumi", "Rumi", "Religion", "N/A", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("270", "The Analects", "N/A", "Religion", "N/A", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("280", "The Dead Sea Scrolls", "N/A", "Religion", "N/A", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("290", "The Upanishads", "N/A", "Religion", "N/A", "N/A", "On-Shelf");

            /* <========================================================> */

            // 300 | Social Sciences
            Database._Instance.DatabaseOfBooks.Rows.Add("300", "The Communist Manifesto", "Karl Marx & Friedrich Engels", "Social Sciences", "1848", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("310", "The Wealth of Nations", "Adam Smith", "Social Sciences", "1776", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("320", "The Feminine Mystique", "Betty Friedan", "Social Sciences", "1963", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("330", "Democracy in America", "Alexis de Tocqueville", "Social Sciences", "1835", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("340", "The Sociological Imagination", "C. Wright Mills", "Social Sciences", "1959", "N/A", "On-Shelf");

            Database._Instance.DatabaseOfBooks.Rows.Add("350", "The Second Sex", "Simone de Beauvoir", "Social Sciences", "1949", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("360", "Pedagogy of the Oppressed", "Paulo Freire", "Social Sciences", "1968", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("370", "Bowling Alone: The Collapse and Revival of American Community", "Robert D. Putnam", "Social Sciences", "2000", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("380", "The Protestant Ethic and the Spirit of Capitalism", "Max Weber", "Social Sciences", "1905", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("390", "The Souls of Black Folk", "W. E. B. Du Bois", "Social Sciences", "1903", "N/A", "On-Shelf");

            /* <========================================================> */

            // 400 | Language
            Database._Instance.DatabaseOfBooks.Rows.Add("400", "The Unfolding of Language", "Guy Deutscher", "Language", "2005", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("410", "Metaphors We Live By", "George Lakoff & Mark Johnson", "Language", "1980", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("420", "The Language Instinct", "Steven Pinker", "Language", "1994", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("430", "On Writing: A Memoir of the Craft", "Stephen King ", "Language", "2000", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("440", "Eats, Shoots & Leaves", "Lynne Truss", "Language", "2003", "N/A", "On-Shelf");

            Database._Instance.DatabaseOfBooks.Rows.Add("450", "Gödel, Escher, Bach: An Eternal Golden Braid", "Douglas Hofstadter", "Language", "1979", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("460", "The Elements of Style", "William Strunk Jr. & E. B. White", "Language", "1959", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("470", "Language in Thought and Action", "S.I. Hayakawa", "Language", "1949", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("480", "How Language Works: How Babies Babble, Words Change Meaning, and Languages Live or Die", "David Crystal", "Language", "2005", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("490", "Mother Tongue: The Story of the English Language", "Bill Bryson", "Language", "1990", "N/A", "On-Shelf");

            /* <========================================================> */

            // 500 | Natural Science and Mathematics
            Database._Instance.DatabaseOfBooks.Rows.Add("500", "On the Origin of Species", "Charles Darwin", "Natural Science and Mathematics", "1859", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("510", "A Brief History of Time", "Stephen Hawking", "Natural Science and Mathematics", "1988", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("520", "The Double Helix", "James D. Watson", "Natural Science and Mathematics", "1968", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("530", "Silent Spring", "Rachel Carson", "Natural Science and Mathematics", "1962", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("540", "The Selfish Gene", "Richard Dawkins", "Natural Science and Mathematics", "1976", "N/A", "On-Shelf");

            Database._Instance.DatabaseOfBooks.Rows.Add("550", "The Structure of Scientific Revolutions", "Thomas S. Kuhn", "Natural Science and Mathematics", "1962", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("560", "Gödel, Escher, Bach: An Eternal Golden Braid", "Douglas Hofstadter", "Natural Science and Mathematics", "1979", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("570", "The Demon-Haunted World: Science as a Candle in the Dark", "Carl Sagan", "Natural Science and Mathematics", "1995", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("580", "The Elegant Universe", "Brian Greene", "Natural Science and Mathematics", "1999", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("590", "Cosmos", "Carl Sagan", "Natural Science and Mathematics", "1980", "N/A", "On-Shelf");

            /* <========================================================> */

            // 600 | Technology (Applied Sciences)
            Database._Instance.DatabaseOfBooks.Rows.Add("600", "The Innovator's Dilemma", "Clayton M. Christensen", "Technology (Applied Sciences)", "1997", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("610", "The Singularity is Near", "Ray Kurzweil", "Technology (Applied Sciences)", "2005", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("620", "Hackers: Heroes of the Computer Revolution", "Steven Levy", "Technology (Applied Sciences)", "1984", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("630", "The Cathedral and the Bazaar", "Eric S. Raymond", "Technology (Applied Sciences)", "1999", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("640", "Steve Jobs", "Walter Isaacson", "Technology (Applied Sciences)", "2011", "N/A", "On-Shelf");

            Database._Instance.DatabaseOfBooks.Rows.Add("650", "The Second Machine Age: Work, Progress, and Prosperity in a Time of Brilliant Technologies", "Erik Brynjolfsson & Andrew McAfee", "Technology (Applied Sciences)", "2014", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("660", "Algorithms to Live By: The Computer Science of Human Decisions", "Brian Christian & Tom Griffiths", "Technology (Applied Sciences)", "2016", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("670", "The Master Switch: The Rise and Fall of Information Empires", "Tim Wu", "Technology (Applied Sciences)", "2010", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("680", "The Big Switch: Rewiring the World, from Edison to Google", "Nicholas Carr", "Technology (Applied Sciences)", "2008", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("690", "Where Wizards Stay Up Late: The Origins of the Internet", "Katie Hafner & Matthew Lyon", "Technology (Applied Sciences)", "1996", "N/A", "On-Shelf");

            /* <========================================================> */

            // 700 | Arts
            Database._Instance.DatabaseOfBooks.Rows.Add("700", "Ways of Seeing", "John Berger", "Arts", "1972", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("710", "The Art of War", "Sun Tzu", "Arts", "N/A", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("720", "Steal Like an Artist: 10 Things Nobody Told You About Being Creative", "Austin Kleon", "Arts", "2012", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("730", "Zen in the Art of Writing", "Ray Bradbury", "Arts", "1990", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("740", "The War of Art: Break Through the Blocks and Win Your Inner Creative Battles", "Steven Pressfield", "Arts", "2002", "N/A", "On-Shelf");

            Database._Instance.DatabaseOfBooks.Rows.Add("750", "The Hero with a Thousand Faces", "Joseph Campbell", "Arts", "1949", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("760", "Bird by Bird: Some Instructions on Writing and Life", "Anne Lamott", "Arts)", "1994", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("770", "Art Through the Ages", "Helen Gardner", "Arts", "1926", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("780", "A People's History of the United States", "Howard Zinn", "Arts", "1980", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("790", "The Power of Myth", "Joseph Campbell", "Arts", "1988", "N/A", "On-Shelf");

            /* <========================================================> */

            // 800 | Literature
            Database._Instance.DatabaseOfBooks.Rows.Add("800", "Don Quixote", "Miguel de Cervantes", "Literature", "1605", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("810", "To Kill a Mockingbird", "Harper Lee", "Literature", "1960", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("820", "Pride and Prejudice", "Jane Austen", "Literature", "1813", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("830", "The Great Gatsby", "Scott Fitzgerald", "Literature", "1925", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("840", "War and Peace", "Leo Tolstoy", "Literature", "1869", "N/A", "On-Shelf");

            Database._Instance.DatabaseOfBooks.Rows.Add("850", "One Hundred Years of Solitude", "Gabriel García Márquez", "Literature", "1967", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("860", "The Catcher in the Rye", "J.D. Salinger", "Literature", "1951", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("870", "1984", "George Orwell", "Literature", "1949", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("880", "The Canterbury Tales", "Geoffrey Chaucer", "Literature", "N/A", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("890", "The Odyssey", "Homer", "Literature", "N/A", "N/A", "On-Shelf");

            /* <========================================================> */

            // 900 | Geography and History
            Database._Instance.DatabaseOfBooks.Rows.Add("900", "Guns, Germs, and Steel", "Jared Diamond", "Geography and History", "1997", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("910", "A Short History of Nearly Everything", "Bill Bryson", "Geography and History", "2003", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("920", "1491: New Revelations of the Americas Before Columbus", "Charles C. Mann", "Geography and History", "2005", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("930", "Sapiens: A Brief History of Humankind", "Yuval Noah Harari", "Geography and History", "2011", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("940", "The Making of the Atomic Bomb", "Richard Rhodes", "Geography and History", "1986", "N/A", "On-Shelf");

            Database._Instance.DatabaseOfBooks.Rows.Add("950", "The Guns of August", "Barbara Tuchman", "Geography and History", "1962", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("960", "The Origins of Political Order", "Francis Fukuyama", "Geography and History", "2011", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("970", "Longitude: The True Story of a Lone Genius Who Solved the Greatest Scientific Problem of His Time", "Dava Sobel", "Geography and History", "1995", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("980", "Salt: A World History", "Mark Kurlansky", "Geography and History", "2002", "N/A", "On-Shelf");
            Database._Instance.DatabaseOfBooks.Rows.Add("990", "", "", "Geography and History", "", "N/A", "On-Shelf");

            /* <========================================================> */
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
