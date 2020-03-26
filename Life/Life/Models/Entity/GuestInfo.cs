namespace Life.Models.Entity
{
    /// <summary>
    /// 賓客資訊entity
    /// </summary>
    public class GuestInfo
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 人數
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// 桌號
        /// </summary>
        public int TableNumber { get; set; }

        /// <summary>
        /// 備註
        /// </summary>
        public string Remark { get; set; }
    }
}