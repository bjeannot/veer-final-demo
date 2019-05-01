using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class QA {

	[Test]
	public void QASimplePasses() {

        // Create a room test

        bool roomSuccess = RoomManager.Instance.CreateRoom("AnandaPoudel");
        Assert.AreEqual(roomSuccess, true);
       
		// Use the Assert class to test conditions.
	}

    
	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode
	[UnityTest]
	public IEnumerator QAWithEnumeratorPasses() {
		// Use the Assert class to test conditions.
		// yield to skip a frame
		yield return null;
	}


}
