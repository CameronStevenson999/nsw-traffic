using System;
using System.Collections.Generic;
using System.Text;

namespace nsw_open_data.Models
{
 
    public class CurrentTrafficIncidentsModel
    {
        public string type { get; set; }
        public Rights rights { get; set; }
        public string layerName { get; set; }
        public long lastPublished { get; set; }
        public Feature[] features { get; set; }
    }

    public class Rights
    {
        public string copyright { get; set; }
        public string licence { get; set; }
    }

    public class Feature
    {
        public string type { get; set; }
        public int id { get; set; }
        public Geometry geometry { get; set; }
        public Properties properties { get; set; }
    }

    public class Geometry
    {
        public string type { get; set; }
        public float[] coordinates { get; set; }
    }

    public class Properties
    {
        public Weblink[] webLinks { get; set; }
        public string headline { get; set; }
        public Period[] periods { get; set; }
        public int speedLimit { get; set; }
        public object webLinkUrl { get; set; }
        public object expectedDelay { get; set; }
        public bool ended { get; set; }
        public bool isNewIncident { get; set; }
        public string publicTransport { get; set; }
        public bool impactingNetwork { get; set; }
        public string subCategoryB { get; set; }
        public object[] arrangementAttachments { get; set; }
        public bool isInitialReport { get; set; }
        public long created { get; set; }
        public bool isMajor { get; set; }
        public object name { get; set; }
        public string subCategoryA { get; set; }
        public string adviceB { get; set; }
        public string adviceA { get; set; }
        public long end { get; set; }
        public string incidentKind { get; set; }
        public string mainCategory { get; set; }
        public long lastUpdated { get; set; }
        public string otherAdvice { get; set; }
        public object[] arrangementElements { get; set; }
        public string diversions { get; set; }
        public string[] additionalInfo { get; set; }
        public object webLinkName { get; set; }
        public string[] attendingGroups { get; set; }
        public object duration { get; set; }
        public long start { get; set; }
        public string displayName { get; set; }
        public object[] media { get; set; }
        public Road[] roads { get; set; }
        public Encodedpolyline[] encodedPolylines { get; set; }
    }

    public class Weblink
    {
        public string linkText { get; set; }
        public string linkURL { get; set; }
    }

    public class Period
    {
        public string closureType { get; set; }
        public string direction { get; set; }
        public string finishTime { get; set; }
        public string fromDay { get; set; }
        public string startTime { get; set; }
        public string toDay { get; set; }
    }

    public class Road
    {
        public string conditionTendency { get; set; }
        public string crossStreet { get; set; }
        public string delay { get; set; }
        public Impactedlane[] impactedLanes { get; set; }
        public string locationQualifier { get; set; }
        public string mainStreet { get; set; }
        public string quadrant { get; set; }
        public int queueLength { get; set; }
        public string region { get; set; }
        public string secondLocation { get; set; }
        public string suburb { get; set; }
        public string trafficVolume { get; set; }
    }

    public class Impactedlane
    {
        public string affectedDirection { get; set; }
        public string closedLanes { get; set; }
        public string description { get; set; }
        public string extent { get; set; }
        public string numberOfLanes { get; set; }
        public string roadType { get; set; }
    }

    public class Encodedpolyline
    {
        public string coords { get; set; }
        public string levels { get; set; }
    }

}
