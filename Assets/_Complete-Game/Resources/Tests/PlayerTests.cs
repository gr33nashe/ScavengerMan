using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class PlayerTests
    {
        // A Test behaves as an ordinary method
        [Test]
        public void PlayerTestsSimplePasses()
        {
            // Use the Assert class to test conditions
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [Test]
        public void FoodIsAlwaysNonNegative()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            Player player = new Player();
            player.food = 10;
            player.LoseFood(10000);
            Assert.GreaterOrEqual(player.food,0);
        }

        [Test]
        public void PlayerLosesFood()
        {
            Player player = new Player();
            player.food = 10;
            player.LoseFood(10);
            Assert.AreEqual(0, player.food);
        }

        [Test]
        public void PlayerDealsWallDamage()
        {
            Player player = new Player();
            Assert.GreaterOrEqual(player.wallDamage, 0);
        }



    }
    public class Player
    {
        public float restartLevelDelay = 1f;        //Delay time in seconds to restart level.
        public int pointsPerFood = 10;              //Number of points to add to player food points when picking up a food object.
        public int pointsPerSoda = 20;              //Number of points to add to player food points when picking up a soda object.
        public int wallDamage = 1;                  //How much damage a player does to a wall when chopping it.

                 //Used to store a reference to the Player's animator component.
        public int food;                           //Used to store player food points total during level.

        
        //LoseFood is called when an enemy attacks the player.
        //It takes a parameter loss which specifies how many points to lose.
        public void LoseFood(int loss)
        {
            //Subtract lost food points from the players total.
            food -= loss;

        }
    }
}
