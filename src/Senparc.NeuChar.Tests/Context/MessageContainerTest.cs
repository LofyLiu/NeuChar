﻿#region Apache License Version 2.0
/*----------------------------------------------------------------

Copyright 2021 Jeffrey Su & Suzhou Senparc Network Technology Co.,Ltd.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file
except in compliance with the License. You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
either express or implied. See the License for the specific language governing permissions
and limitations under the License.

Detail: https://github.com/JeffreySu/WeiXinMPSDK/blob/master/license.md

----------------------------------------------------------------*/
#endregion Apache License Version 2.0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Senparc.NeuChar.Context;
using Senparc.NeuChar.Entities;
using Senparc.Weixin.MP.Entities;

namespace Senparc.NeuChar.Tests.Context
{
    [TestClass]
    public class MessageContainerTest
    {
        [TestMethod]
        public void AddTest()
        {

            var list = new MessageContainer<RequestMessageBase>(-1);

            //测试不限量添加
            for (int i = 0; i < 1000; i++)
            {
                list.Add(new RequestMessageText()
                {
                    Content = i.ToString()
                }); ;
            }
            Assert.AreEqual(1000, list.Count);

            //限量
            list.MaxRecordCount = 100;//限量100条
            for (int i = 0; i < 1000; i++)
            {
                list.Add(new RequestMessageText()
                {
                    Content = i.ToString()
                });
            }
            Assert.AreEqual(100, list.Count);
        }

        [TestMethod]
        public void AddRangeTest()
        {
            var list = new MessageContainer<RequestMessageBase>(10);//限量10条

            for (int i = 0; i < 1000; i++)
            {
                list.AddRange(new[] { new RequestMessageText()
                {
                    Content = i.ToString()
                }, new RequestMessageText()
                {
                    Content = (i+1).ToString()
                }, new RequestMessageText()
                {
                    Content = (i+2).ToString()
                } });
            }
            Assert.AreEqual(10, list.Count);
        }

        [TestMethod]
        public void InsertTest()
        {
            var list = new MessageContainer<RequestMessageBase>(10);//限量10条

            for (int i = 0; i < 1000; i++)
            {
                list.Insert(0, new RequestMessageText()
                {
                    Content = i.ToString()
                });
            }
            Assert.AreEqual(10, list.Count);
            Assert.AreEqual(9, int.Parse(((RequestMessageText)list[0]).Content));
        }

        [TestMethod]
        public void InsertRangeTest()
        {
            var list = new MessageContainer<RequestMessageBase>(10);//限量10条

            for (int i = 0; i < 1000; i++)
            {
                list.InsertRange(0, new[] { new RequestMessageText()
                {
                    Content = i.ToString()
                }, new RequestMessageText()
                {
                    Content = (i+1).ToString()
                }, new RequestMessageText()
                {
                    Content = (i+2).ToString()
                } });

                //i=0:0,1,2
                //i=1:1,2,3,0,1,2
                //i=2:2,3,4,1,2,3,0,1,2
                //i=3:3,4,5,2,3,4,1,2,3,0,1,2 -> 5,2,3,4,1,2,3,0,1,2
            }
            Assert.AreEqual(10, list.Count);
            Assert.AreEqual(5, int.Parse(((RequestMessageText)list[0]).Content));
            Assert.AreEqual(2, int.Parse(((RequestMessageText)list[1]).Content));
            Assert.AreEqual(3, int.Parse(((RequestMessageText)list[2]).Content));
            Assert.AreEqual(4, int.Parse(((RequestMessageText)list[3]).Content));
        }
    }
}
