using System;
using System.Text;
using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.Tests;

[TestFixture]
public class CargoManagementSystemTests
{
    [Test]
    public void Test_Constructor_CheckInitialEmptyCargoCollectionAndCount()
    {
        // Arrange & Act
        var cargoSystem = new CargoManagementSystem();

        // Assert
        Assert.AreEqual(0, cargoSystem.CargoCount);
        Assert.IsEmpty(cargoSystem.GetAllCargos());
    }

    [Test]
    public void Test_AddCargo_ValidCargoName_AddNewCargo()
    {
        // Arrange
        var cargoSystem = new CargoManagementSystem();

        // Act
        cargoSystem.AddCargo("Cargo1");

        // Assert
        Assert.AreEqual(1, cargoSystem.CargoCount);
        Assert.Contains("Cargo1", cargoSystem.GetAllCargos());
    }

    [Test]
    public void Test_AddCargo_NullOrEmptyCargoName_ThrowsArgumentException()
    {
        // Arrange
        var cargoSystem = new CargoManagementSystem();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => cargoSystem.AddCargo(null));
        Assert.Throws<ArgumentException>(() => cargoSystem.AddCargo(""));
        Assert.Throws<ArgumentException>(() => cargoSystem.AddCargo(" "));
    }

    [Test]
    public void Test_RemoveCargo_ValidCargoName_RemoveFirstCargoName()
    {
        // Arrange
        var cargoSystem = new CargoManagementSystem();
        cargoSystem.AddCargo("Cargo1");
        cargoSystem.AddCargo("Cargo2");

        // Act
        cargoSystem.RemoveCargo("Cargo1");

        // Assert
        Assert.AreEqual(1, cargoSystem.CargoCount);
        Assert.IsFalse(cargoSystem.GetAllCargos().Contains("Cargo1"));
        Assert.Contains("Cargo2", cargoSystem.GetAllCargos());
    }

    [Test]
    public void Test_RemoveCargo_NullOrEmptyCargoName_ThrowsArgumentException()
    {
        // Arrange
        var cargoSystem = new CargoManagementSystem();
        cargoSystem.AddCargo("Cargo1");

        // Act & Assert
        Assert.Throws<ArgumentException>(() => cargoSystem.RemoveCargo("Cargo2"));
    }

    [Test]
    public void Test_GetAllCargos_AddedAndRemovedCargos_ReturnsExpectedCargoCollection()
    {
        // Arrange
        var cargoSystem = new CargoManagementSystem();
        cargoSystem.AddCargo("Cargo1");
        cargoSystem.AddCargo("Cargo2");
        cargoSystem.AddCargo("Cargo3");
        cargoSystem.RemoveCargo("Cargo2");

        // Act
        List<string> result = cargoSystem.GetAllCargos();

        // Assert
        Assert.AreEqual(2, result.Count);
        Assert.Contains("Cargo1", result);
        Assert.Contains("Cargo3", result);
        Assert.IsFalse(result.Contains("Cargo2"));
    }
}

    