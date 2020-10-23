using System;
using NUnit.Framework;

namespace RotateMatrix.Tests
{
    public class ArrayExtensionsTestsRotateCounterСlockwise
    {
        [TestCaseSource(typeof(TestCasesSource), nameof(TestCasesSource.TestCasesRotate90DegreesCounterСlockwise))]
        public void Rotate90DegreesCounterСlockwise_Tests(int[,] matrix, int[,] rotatedMatrix)
        {
            matrix.Rotate90DegreesCounterСlockwise();
            Assert.AreEqual(rotatedMatrix, matrix);
        }
        
        [Test]
        public void Rotate90DegreesCounterСlockwise_MatrixIsNull_ThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() =>  ArrayExtensions.Rotate90DegreesCounterСlockwise(null));
        }
        
        [TestCaseSource(typeof(TestCasesSource), nameof(TestCasesSource.TestCasesRotate180DegreesCounterСlockwise))]
        public void Rotate180DegreesCounterСlockwise_Tests(int[,] matrix, int[,] rotatedMatrix)
        {
            matrix.Rotate180DegreesCounterСlockwise();
            Assert.AreEqual(rotatedMatrix, matrix);
        }
        
        [Test]
        public void Rotate180DegreesCounterСlockwise_MatrixIsNull_ThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() =>  ArrayExtensions.Rotate180DegreesCounterСlockwise(null));
        }
        
        [TestCaseSource(typeof(TestCasesSource), nameof(TestCasesSource.TestCasesRotate270DegreesCounterСlockwise))]
        public void Rotate270DegreesCounterСlockwise_Tests(int[,] matrix, int[,] rotatedMatrix)
        {
            matrix.Rotate270DegreesCounterСlockwise();
            Assert.AreEqual(rotatedMatrix, matrix);
        }
        
        [Test]
        public void Rotate270DegreesCounterСlockwise_MatrixIsNull_ThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() =>  ArrayExtensions.Rotate270DegreesCounterСlockwise(null));
        }
        
        [TestCaseSource(typeof(TestCasesSource), nameof(TestCasesSource.TestCasesRotate360DegreesCounterСlockwise))]
        public void Rotate360DegreesCounterСlockwise_Tests(int[,] matrix, int[,] rotatedMatrix)
        {
            matrix.Rotate360DegreesCounterСlockwise();
            Assert.AreEqual(rotatedMatrix, matrix);
        }
        
        [Test]
        public void Rotate360DegreesCounterСlockwise_MatrixIsNull_ThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() =>  ArrayExtensions.Rotate360DegreesCounterСlockwise(null));
        }
    }
}