using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Goods
    {
        private double goodsValue;
        public Goods(uint id, string name, double value) {
            GoodsId = id;
            GoodsName = name;
            GoodsValue = value;
        }
        public uint GoodsId { get; set; }
        public string GoodsName { get; set; }
        public double GoodsValue {
            get { return goodsValue; }
            set {
                if (value >= 0)
                    goodsValue = value;
                else
                    throw new ArgumentOutOfRangeException("value must >= 0!");
            }
        }
        public override string ToString() {
            return "goodsId:{GoodsId}, goodsName:{GoodsName}, goodsValue:{GoodsValue}";
        }
    }
}
