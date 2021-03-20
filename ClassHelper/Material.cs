namespace wsrtest.EF
{
    public partial class Material
    {
        public string GetName { get => MaterialName + "  |  " + MaterialType.MaterialTypeName; }
        public string GetMinQTY { get => "Минимальное количество: " + MinQTY + Unit.UnitName; }
        public string GetStockQTY { get => "Остаток: " + StockQTY + Unit.UnitName; }

        public string GetSupplier { 
            get
            {
                string suppliers = string.Empty;

                foreach (var item in Supplier)
                {
                    if (suppliers != string.Empty)
                    {
                        suppliers += ", ";
                    }
                    suppliers += item.SupplierName;
                }

                if (suppliers != string.Empty)
                {
                    return "Поставщики: " + suppliers;
                }
                else
                {
                    return "Поставщики отсутствуют" + suppliers;
                }
            } 
        }


        public string GetImage
        {
            get
            {
                if (Image != "")
                {
                    return "/Photo" + Image;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}