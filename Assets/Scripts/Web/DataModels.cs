﻿/**
 * Copyright (c) 2020 LG Electronics, Inc.
 *
 * This software contains code licensed as described in LICENSE.
 *
 */

using PetaPoco;
using Simulator.Utilities;
using System;
using System.Collections.Generic;

namespace Simulator.Web
{    
    public class MapData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string AssetGuid { get; set; }
        public string OwnerId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class MapDetailData: MapData
    {
        public bool IsShared { get; set; }
        public bool IsFavored { get; set; }
        public bool IsOwned { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string SupportedPlatforms { get; set; }
        public string Version { get; set; }
        public string LicenseName { get; set; }
        public string AuthorName { get; set; }
        public string AuthorUrl { get; set; }
        public string Copyright { get; set; }
        public string Hdmaps { get; set; }
        public string AccessType { get; set; }
        public TagData[] Tags { get; set; }
        public OwnerData Owner { get; set; }
    }

    public class TagData
    {
        public string Name;
    }

    public class OwnerData
    {
        public string id {get; set; }
        public string email {get; set; }
        public string firstName {get; set; }
        public string lastName {get; set; }
    }

    public class VehicleData
    {
        public string Id { get; set; }
        public string OwnerId { get; set; }
        public string Name { get; set; }
        public string AssetGuid { get; set; }
        public SensorData[] Sensors { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public BridgeData bridge { get; set; }
    }

    public class VehicleDetailData: VehicleData
    {
        public bool IsShared { get; set; }
        public bool IsFavored { get; set; }
        public bool IsOwned { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Version { get; set; }
        public string LicenseName { get; set; }
        public string AuthorName { get; set; }
        public string AuthorUrl { get; set; }
        public string Copyright { get; set; }
        public string fmu { get; set; }
        public string AccessType { get; set; }
        public string BridgePluginId { get; set; }
        public TagData[] Tags { get; set; }
        public OwnerData Owner { get; set; }
        public string[] favoredBy {get; set; }
        public string[] sharedWith {get; set; }
    }

    public class BridgeData
    {
        public string name { get; set; }
        public string assetGuid { get; set; }
        public string type { get; set; }
        public string connectionString { get; set; }
    }
    
    public class ClusterData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string OwnerId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public InstanceData[] Instances { get; set; }
    }

    public class InstanceData
    {
        public string SimId;
        public string[] Ip;
        public bool IsMaster;
    }

    public class SensorData
    {
        public string name;
        public string parent;
        public string type;
        public TransformData transform;
        public string assetGuid;
        public Dictionary<string, object> @params; 
    }

    public class TransformData
    {
        public float x;
        public float y;
        public float z;
        public float pitch;
        public float yaw;
        public float roll;
    }
    
    public class SimulationData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string OwnerId { get; set; }
        public bool ApiOnly { get; set; }
        public bool Interactive { get; set; }
        public bool Headless { get; set; }
        public DateTime TimeOfDay { get; set; }
        public float Rain { get; set; }
        public float Fog { get; set; }
        public float Wetness { get; set; }
        public float Cloudiness { get; set; }
        public int Seed { get; set; }
        public bool UseTraffic { get; set; }
        public bool UseBicyclists { get; set; }
        public bool UsePedestrians { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public MapData Map { get; set; }
        public VehicleData[] Vehicles { get; set; }
        public ClusterData Cluster { get; set; }
    }
}