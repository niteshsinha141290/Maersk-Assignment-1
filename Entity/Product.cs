namespace Assignment1.Entity
{
    public class Product
    {
        private decimal _price = 0;

        public Product(string type)
        {
            this.Type = type;
        }

        public string Type { get; set; }
        public decimal Price {
            get
            {
                switch (this.Type)
                {
                    case "A":
                        _price = 50;

                        break;
                    case "B":
                        _price = 30;

                        break;
                    case "C":
                        _price = 20;

                        break;
                    case "D":
                        _price = 15;
                        break;
                }

                return _price;
            }

            set 
            {
                this.Price = value;
            }
        }
    }
}
