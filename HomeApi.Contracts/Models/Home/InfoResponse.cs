namespace HomeApi.Contracts.Home
{
    /// <summary>
    /// Информация о вашем доме (модель ответа)
    /// </summary>
    public class InfoResponse
    {
        public int FloorAmount { get; set; }

        public string Telephone { get; set; }

        public string Heating { get; set; }

        public int CurrentVolts { get; set; }

        public bool GasConnected { get; set; }

        public int Area { get; set; }

        public string Material { get; set; }

        public AddressInfo AddressInfo { get; set; }
    }
}
