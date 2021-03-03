using System;
using System.Linq;
using Xunit;
using Microsoft.EntityFrameworkCore;
using FestivalsOverview.DAL;
using FestivalsOverview.DAL.Entities;
using FestivalsOverview.DAL.Enums;

namespace FestivalsOverview.DAL.Tests
{
    public sealed class FestivalsOverviewDbContextTests : IDisposable 
    {
        private readonly DbContextInMemoryFactory _dbContextFactory;
        // SUT - System Under Test - testovaná èást
        private readonly FestivalsOverviewDbContext _festivalOverviewDbContextSUT;

        public FestivalsOverviewDbContextTests()
        {
            _dbContextFactory = new DbContextInMemoryFactory(nameof(FestivalsOverviewDbContextTests));
            _festivalOverviewDbContextSUT = _dbContextFactory.Create();
            _festivalOverviewDbContextSUT.Database.EnsureCreated();
        }


        [Fact]
        public void AddNew_Band_Persisted()
        {
            var bandEntity = new BandEntity("Kabát",Genres.House, Countries.AE, "test", "test");

            _festivalOverviewDbContextSUT.Bands.Add(bandEntity);
            _festivalOverviewDbContextSUT.SaveChanges();

            using var dbx = _dbContextFactory.Create();
            var retrievedBand = dbx.Bands.Single(entity => entity.Id == bandEntity.Id);
            Assert.Equal(bandEntity, retrievedBand, BandEntity.CountryGenreNameIdComparer);
        }


        [Fact]
        public void AddNew_Stage_persisted()
        {
            var stageEntity = new StageEntity("test", "Some description", "test");

            _festivalOverviewDbContextSUT.Stages.Add(stageEntity);
            _festivalOverviewDbContextSUT.SaveChanges();

            using var dbx = _dbContextFactory.Create();
            
            var retrievedStage = dbx.Stages.Single(e => e.Id == stageEntity.Id);
            Assert.Equal(stageEntity, retrievedStage, StageEntity.StageEqualityComparer);
            
        }

        // Clear
        public void Dispose() => _festivalOverviewDbContextSUT?.Dispose();

    }
}
