using System;
using AbstractFactory;
using Builder;
using FactoryMethod;
using Singleton;
using Xunit;


namespace GoFTests
{
    public class GoFTests
    {
        #region Singleton

        [Fact]
        public void Singleton_GetInstance_WhenToCall_ReturnSingleIntance()
        {
            // Arrange

            // ACT
            var instance1 = Instance.GetInstance();
            var instance2 = Instance.GetInstance();


            // Assert
            Assert.True(instance1.Equals(instance2));
        }

        #endregion

        #region Factory Method

        [Fact]
        public void FactoryMethod_CriarPassagemUrbano_WhenToCall_ReturnPassagem()
        {
            // Arrange

            // ACT
            var pUrbano = new MyFactoryMethod().CriarPassagemUrbano();

            // Assert
            Assert.IsType<FactoryMethod.PassagemOnibusUrbano>(pUrbano);
        }

        // TODO: Criar Stub para este teste
        [Fact]
        public void FactoryMethod_CriarPassagemInterEstadual_WhenToCall_ReturnPassagem()
        {
            // Arrange

            // ACT
            var pInter = new MyFactoryMethod().CriarPassagemOnibusInter();

            // Assert
            Assert.IsType<FactoryMethod.PassagemOnibusInterEstadual>(pInter);
        }

        #endregion

        #region Abstract Factory
        [Fact]
        public void AbstractFactory_CriarPassagemUrbano_WhenToCall_ReturnPassagem()
        {
            // Arrange

            // ACT
            var pUrbano = new MyAbstractFactory().CriarPassagemOnibusUrbano();

            // Assert
            Assert.IsType<ConcretePassagemOnibusUrbano>(pUrbano);
        }

        [Fact]
        public void AbstractFactory_CriarPassagemInterEstadual_WhenToCall_ReturnPassagem()
        {
            // Arrange

            // ACT
            var pInter = new MyAbstractFactory().CriarPassagemOnibusInterEstadual();

            // Assert
            Assert.IsType<ConcretePassagemOnibusInterEstadual>(pInter);
        }

        [Fact]
        public void Builder_FazSanduiche_InputHamburgerBuilder_ReturnHamburger()
        {
            // Arrange
            var hamburguer = new HamburguerBuilder();
            
            // ACT
            var sanduiche = new Cozinha().FazSanduiche(hamburguer);

            // Assert
            Assert.IsType<Hamburguer>(sanduiche);
        }

        [Fact]
        public void Builder_FazSanduiche_InputFishBuilder_ReturnFishBurger()
        {
            // Arrange
            var fishBurger = new FishBuilder();
            
            // ACT
            var sanduiche = new Cozinha().FazSanduiche(fishBurger);
            
            // Assert
            Assert.IsType<FishBurguer>(sanduiche);
        }

        #endregion
    }
}