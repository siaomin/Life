namespace Life.Models.Entity
{
    /// <summary>
    /// 賓客資訊entity
    /// </summary>
    public class GuestInfo
    {
        /// <summary>
        /// 編號
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 性別
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 電話
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// 手機號碼
        /// </summary>
        public string Cellphone { get; set; }
    }
}