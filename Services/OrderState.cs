using BlazingPizza.Shared;

namespace BlazingPizza.Services
{
    public class OrderState
    {
        public bool ShowingConfigDialog { get; private set; }
        public Pizza ConfigPizza { get; private set; }
        public Order Order { get; private set; } = new();

        public void ShowPizzaConfigDialog(PizzaSpecial special)
        {
            // Copy Configuration Pizza from Selected Special, Flag Dialog Window as Visible
            ConfigPizza = new()
            {
                Special = special,
                SpecialId = special.Id,
                Size = Pizza.DefaultSize,
                Toppings = new List<PizzaTopping>()
            };

            ShowingConfigDialog = true;
        }

        public void ClosePizzaConfigDialog()
        {
            // Reset Data on Selected Pizza, Flag Dialog Window as Hidden
            ConfigPizza = null;
            ShowingConfigDialog = false;
        }

        public void ConfirmPizzaConfigDialog()
        {
            // Add Current Pizza Data to Order List, Execute Dialog Close Method
            Order.Pizzas.Add(ConfigPizza);            
            ClosePizzaConfigDialog();
        }
    }

    
}