using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class DraggableTestScript
    {
        [Test]
        public void Draggable_Holder_Presence_Test()
        {
            bool checkHolder = MultiStepChecker.IsHolderPresent(true);
            
            Assert.AreEqual(true, checkHolder);
        }

        [Test]
        public void Check_Holder_Object()
        {
            MultiStepInteraction.HolderInfo objectHolder = new MultiStepInteraction.HolderInfo();
            
            Assert.NotNull(objectHolder);
        }
    }
}
