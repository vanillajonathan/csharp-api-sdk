using System.Runtime.Serialization;

namespace FortnoxAPILibrary.Entities
{
    public enum OrderType
    {
        ///<summary> No property description </summary>
        [EnumMember(Value = "Order")]
        Order,
        ///<summary> No property description </summary>
        [EnumMember(Value = "Backorder")]
        Backorder,
    }
}