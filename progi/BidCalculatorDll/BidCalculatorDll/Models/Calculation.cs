namespace BidCalculation.Models
{
    public class Calculation
    {
        public string type {  get; set; }
        public int? price { get; set; }  
        public double? basic {  get; set; }
        public double? special { get; set; }
        public double? association { get; set; }
        public double storage { get; set; } = 100;
        public double? total { get; set; }

        public Calculation() { }

        public Calculation(string type, int price) {
            this.type = type;
            this.price = price;
        }

        public void setAssociation() {
            if (this.price > 0 && this.price <= 500)
            {
                this.association = 5;
            }
            else if (this.price <= 1000)
            {
                this.association = 10;
            }
            else if (this.price <= 3000)
            {
                this.association = 15;
            }
            else
            {
                this.association = 20;
            }
        }

    }
}
