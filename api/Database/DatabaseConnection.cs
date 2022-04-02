namespace api.Database
{
    public class DatabaseConnection
    {
        public string cs { get; set; }

        public DatabaseConnection(){
            string server = "wb39lt71kvkgdmw0.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            string database = "kirydvzhz00lnpkf";
            string port = "3306";
            string userName = "ljefawp8h6bwllgi";
            string password = "p8izugc8w10nxcoe";
            
            cs = $@"server = {server};user={userName};database={database};port={port};password={password};";
        }
    }
}