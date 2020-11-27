# GLEIF API
The GLEIF API is a simple library to perform a GLEIF LEI Search 2.0

## Usage
The API must be intialized, and a search can be performed as follows:

Simple use:
```C#
    GleifApi.GleifCommunicator communicator = new GleifApi.GleifCommunicator();
    string lei = "506700GE1G29325QX363";
    IEnumerable<GleifApi.LeiRecord> records = await comm.GetLeiRecordAsync(lei);
```

Using IHttpClientFactory with dotnet core dependency injection:
```C#
    GleifApi.GleifCommunicator communicator = new GleifApi.GleifCommunicator(httpClientFactory);
    string lei = "506700GE1G29325QX363";
    IEnumerable<GleifApi.LeiRecord> records = await comm.GetLeiRecordAsync(lei);
```

## About GLEIF
The Global Legal Entity Identity Foundation is the non-profit organization which coordinates the creation and management of Legal Entity Identifiers (LEIs). LEIs are globally unique identifiers for organizations.
More information on https://www.gleif.org/

## About OpenSBR
OpenSBR was set up by enthousiasts. The open source projects are made publicly available by a variety of organisations willing to contribute to the adoption of SBR. OpenSBR is a private non-profit initiative.
OpenSBR publishes open source software related to digital data exchange, such as Standard Business Reporting, XBRL, digital signatures and Legal Entity Identifiers.

November 2020
