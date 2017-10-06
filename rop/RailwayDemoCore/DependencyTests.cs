using System;
using CSharpFunctionalExtensions;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace RailwayDemoCore
{
    public class DependencyTests
    {
        [Fact]
        public void FluentAssertions_work_with_dotnet_core() 
            => true.Should().BeTrue();

        [Fact]
        public void NSubstitute_works_with_dotnet_core() 
            => Substitute.For<IFoo>().Blub("test").Returns("test");

        [Fact]
        public void CSharpFunctionalExtensions_work_with_dotnet_core() 
            => Result.Ok().IsSuccess.Should().BeTrue();
    }

    public interface IFoo
    {
        string Blub(string s);
    }
}
