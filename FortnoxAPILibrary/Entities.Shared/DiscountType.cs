using System.Runtime.Serialization;

namespace FortnoxAPILibrary.Entities
{
    public enum DiscountType
    {
        ///<summary> No property description </summary>
        [EnumMember(Value = "AMOUNT")]
        AMOUNT,
        ///<summary> No property description </summary>
        [EnumMember(Value = "PERCENT")]
        PERCENT,
    }
}