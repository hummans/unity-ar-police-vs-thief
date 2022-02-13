using System.Collections;
using System.Collections.Generic;
using Components;
using NUnit.Framework;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

namespace Editor.Tests.Scenes
{    
    public class MainSceneShould
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            EditorSceneManager.OpenScene("Assets/Scenes/main.unity");
        }
        
        [Test]
        public void ar_placement_track_pose_should()
        {
            var component = Component.FindObjectOfType<ARPlacementTrackPose>();
            component.Awake();
            Assert.NotNull(component);
            Assert.NotNull(component.placementPoseController);
            Assert.NotNull(component.enviromentData);
        }

        [Test]
        public void ar_placement_pose_controller()
        {
            var component = Component.FindObjectOfType<PlacementPoseController>();
            Assert.NotNull(component);
            Assert.NotNull(component.raycastManager);
            Assert.NotNull(component.mainCamera);
            Assert.NotNull(component.enviromentData);
        }

        [Test]
        public void placement_indicator_display()
        {
            var component = Component.FindObjectOfType<PlacementIndicatorDisplay>();
            component.Start();
            Assert.NotNull(component);
            Assert.NotNull(component.enviromentData);
            Assert.NotNull(component._renderer);
        }

        [Test]
        public void placement_indicator_pose_display()
        {
            var component = Component.FindObjectOfType<PlacementIndicatorPoseDisplay>();
            Assert.NotNull(component);
            Assert.NotNull(component.enviromentData);
            Assert.NotNull(component._transform);
        }

        [Test]
        public void player_spawner_input()
        {
            var component = Component.FindObjectOfType<PlayerSpawnerInput>();
            Assert.NotNull(component);
            Assert.NotNull(component.gameData);
            Assert.NotNull(component.enviromentData);
            Assert.NotNull(component.gameCmdFactory);
        }

        [Test]
        public void ar_input_manager()
        {
            var component = Component.FindObjectOfType<ARInputManager>();
            Assert.NotNull(component);
        }

        [Test]
        public void game_manager()
        {
            var component = Component.FindObjectOfType<GameController>();
            Assert.NotNull(component);
            Assert.NotNull(component.gameData);
            Assert.NotNull(component.enviromentData);
        }
    }
}
