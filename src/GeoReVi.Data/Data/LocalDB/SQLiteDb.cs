//This code was generated by a tool.
//Changes to this file will be lost if the code is regenerated.
// See the blog post here for help on using the generated code: http://erikej.blogspot.dk/2014/10/database-first-with-sqlite-in-universal.html
using SQLite;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeoReVi
{
    public class SQLiteDb
    {
        string _path;
        public SQLiteDb(string path)
        {
            _path = path;
        }
        
         public void Create()
        {
            using (SQLiteConnection db = new SQLiteConnection(_path))
            {
                db.CreateTable<tblAffiliation>();
                db.CreateTable<tblAlia>();
                db.CreateTable<tblApparentPermeability>();
                db.CreateTable<tblArchEleOccurence>();
                db.CreateTable<tblArchitecturalElement>();
                db.CreateTable<tblBasin>();
                db.CreateTable<tblBasinLithoUnit>();
                db.CreateTable<tblBiochemicalFacy>();
                db.CreateTable<tblBoundingSurfaceArchEle>();
                db.CreateTable<tblBoundingSurface>();
                db.CreateTable<tblBulkDensity>();
                db.CreateTable<tblCountry>();
                db.CreateTable<tblCuboid>();
                db.CreateTable<tblDataQualityRating>();
                db.CreateTable<tblDepositionalEnvironmentCatalogue>();
                db.CreateTable<tblDrillCore>();
                db.CreateTable<tblDrilling>();
                db.CreateTable<tblEffectivePorosity>();
                db.CreateTable<tblEonothem>();
                db.CreateTable<tblErathem>();
                db.CreateTable<tblFacy>();
                db.CreateTable<tblFaciesCode>();
                db.CreateTable<tblFaciesLithostrat>();
                db.CreateTable<tblFaciesObservation>();
                db.CreateTable<tblFileFieldMeasurement>();
                db.CreateTable<tblFileLabMeasurement>();
                db.CreateTable<tblFileSection>();
                db.CreateTable<tblFormation>();
                db.CreateTable<tblGrainDensity>();
                db.CreateTable<tblGroup>();
                db.CreateTable<tblHandpiece>();
                db.CreateTable<tblIgneousFacy>();
                db.CreateTable<tblIntrinsicPermeability>();
                db.CreateTable<tblLithofacy>();
                db.CreateTable<tblMeasuringDevice>();
                db.CreateTable<tblMessage>();
                db.CreateTable<tblObjectOfInvestigation>();
                db.CreateTable<tblObjectLithostratigraphy>();
                db.CreateTable<tblOutcrop>();
                db.CreateTable<tblPeriod>();
                db.CreateTable<tblPerson>();
                db.CreateTable<tblPetrography1>();
                db.CreateTable<tblPetrography2>();
                db.CreateTable<tblPetrography3>();
                db.CreateTable<tblPetrography4>();
                db.CreateTable<tblPetrography5>();
                db.CreateTable<tblPetrography6>();
                db.CreateTable<tblPetrography7>();
                db.CreateTable<tblPetrography8>();
                db.CreateTable<tblPictureArchitecturalElement>();
                db.CreateTable<tblPictureBasin>();
                db.CreateTable<tblPictureDepositionalEnvironment>();
                db.CreateTable<tblPictureObjectOfInvestigation>();
                db.CreateTable<tblPictureRockSample>();
                db.CreateTable<tblPlug>();
                db.CreateTable<tblPowder>();
                db.CreateTable<tblProject>();
                db.CreateTable<tblRockSample>();
                db.CreateTable<tblSection>();
                db.CreateTable<tblSectionLithofacy>();
                db.CreateTable<tblSectionsPetrography>();
                db.CreateTable<tblSedimentaryStructure>();
                db.CreateTable<tblSery>();
                db.CreateTable<tblSonicWave>();
                db.CreateTable<tblSpectralGammaRay>();
                db.CreateTable<tblStage>();
                db.CreateTable<tblStructureOrientation>();
                db.CreateTable<tblSubformation>();
                db.CreateTable<tblSubgroup>();
                db.CreateTable<tblSusceptibility>();
                db.CreateTable<tblSystem>();
                db.CreateTable<tblThermalConductivity>();
                db.CreateTable<tblThermalDiffusivity>();
                db.CreateTable<tblThinSection>();
                db.CreateTable<tblThinSectionPointCounting>();
                db.CreateTable<tblTotalGammaRay>();
                db.CreateTable<tblTransect>();
                db.CreateTable<tblUnionLithostratigraphy>();
                db.CreateTable<tblVolcanicFacy>();
                db.CreateTable<tblXRayFluorescenceSpectroscopy>();
            }
        }
    }
}
