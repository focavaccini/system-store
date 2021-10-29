namespace system_store{
    class OrderItem{
        public double Price { get; private set; }
        public int Quantity { get; set; }

        public OrderItem(){

        }

        public OrderItem(double price, int quantity){
            Price = price;
            Quantity = quantity;
        }

        public double SubTotal(){
            return Price * Quantity;
        }
    }
}