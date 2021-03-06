using Newtonsoft.Json;

namespace CloudCoinCsharpSDK
{
    class BankTotal : IBankResponse
    {

        //Fields
        [JsonProperty("ones")]
        public int ones { get; set; }

        [JsonProperty("fives")]
        public int fives { get; set; }

        [JsonProperty("twentyfives")]
        public int twentyfives { get; set; }

        [JsonProperty("hundreds")]
        public int hundreds { get; set; }

        [JsonProperty("twohundredfifties")]
        public int twohundredfifties { get; set; }

        [JsonProperty("bank_server")]
        public string bank_server { get; set; }

        [JsonProperty("status")]
        public string status { get; set; }

        [JsonProperty("time")]
        public string time { get; set; }

        //Constructors
        public BankTotal()
        {

        }//end of constructor

        public BankTotal(int ones, int fives, int twentyfives, int hundreds, int twohundredfifties)
        {
            this.ones = ones;
            this.fives = fives;
            this.twentyfives = twentyfives;
            this.hundreds = hundreds;
            this.twohundredfifties = twohundredfifties;

        }//end of constructor


    }
}
