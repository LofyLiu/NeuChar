﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senparc.NeuChar.NeuralSystems
{
    public class BaseNeuralNode : INeuralNode
    {
        //TODO:使用命名空间以及唯一标识Guid来区分
        //public abstract string Namespace { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        public virtual string Version { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public virtual string Name { get; set; }


        ///// <summary>
        ///// 父节点
        ///// </summary>
        //public virtual INeuralNode ParentNode { get; private set; }
        /// <summary>
        /// 所有子节点
        /// </summary>
        public virtual IList<INeuralNode> ChildrenNodes { get; }

        /// <summary>
        /// 设置信息
        /// </summary>
        public BaseNeuralNode Config { get; set; }


        //public object ApiData { get; set; }
        //public object ApiDataKey { get; set; }
        //public object ExtData { get; set; }
        //public object ExtDataKey { get; set; }

        /// <summary>
        /// BaseNeuralNode 构造函数
        /// </summary>
        public BaseNeuralNode()
        {
            ChildrenNodes = new List<INeuralNode>();
        }

        /// <summary>
        /// 设置子节点
        /// </summary>
        /// <param name="childNode"></param>
        public virtual void SetChildNode(INeuralNode childNode)
        {
            //childNode.SetParentNode(this);
            ChildrenNodes.Add(childNode);
        }

        //public virtual void SetParentNode(INeuralNode childNode)
        //{
        //    ParentNode = childNode;
        //}
    }
}
