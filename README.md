# MindworkingAssignment
An assignment for Mindworking A/S to test the applicant's abilities as a backend developer. The goal of the assignment is to provide a web service that provide overall lists and details for the programmer's skills and education, as well as previously worked at companies, and projects.

To complete the assignment, the programmer must make use of the following tools:
- C#
- GraphQL

## How to use
As per the requirements, the web service is a single endpoint API utilizing the GraphQL query language.

To get started, simply download the latest release, open it in Visual Studio, and run it from there.
Optionally the project can be deployed to a GraphQL Server, if one is available.

When the web service is running, it can be queried using the GraphQL query language, examples of which are displayed further down.
For testing purpases it is recommended to use Postman (Chrome) or HttpRequester (Firefox), or other equivelant tools.

Query data sent to the web service must be sent as the **application/json** content type. The returned data utilize the same content type.

For a list of available queries, and query models, refer to the **Available Queries** and **Query Models** sections respectively.

#### Endpoint address
All queries made to the web service must be to the URL displayed below.
```
http://localhost:5000/graphql
```
The above is the default address, and can be changed as necessary in the properties of the *Cv.Api* project in the solution.
Note that the **"graphql"** part of the URL must be changed in the **GraphQLController** instead.

#### Querying a list
The following example showcases how to retrieve a list of an applicant's skills, and the output it generates.

##### Query
``` 
{
  query: "query {
    skills {
      id,
      name
    }
  }"
}
```

##### Output
```
{
  "data": {
    "skills": [
      {
        "id": 1,
        "name": "C#"
      },
      {
        "id": 2,
        "name": "MSSQL"
      },
      ...
      ...
    ]
  }
}
```


#### Querying a single item
The following example showcases how to retrieve the details of an applicant's skill, and the output it generates.

##### Query
``` 
{
  query: "query {
    skill(id:1) {
      id,
      name,
      proficiency
    }
  }"
}
```

##### Output
```
{
  "data": {
    "skill": {
      "id": 1,
      "name": "C#",
      "proficiency": "High"
    }
  }
}
```

## Available queries
| Query           | Parameters        | Description  |
|:----------------|:------------------|:-------------|
| companies       | — N/A —           | Retrieves a list of all Companies  |
| educations      | — N/A —           | Retrieves a list of all Educations  |
| projects        | — N/A —           | Retrieves a list of all Projects  |
| skills          | — N/A —           | Retrieves a list of all Skills  |
| company         | id (Integer)      | Retrieves the details of a single Company  |
| education       | id (Integer)      | Retrieves the details of a single Education  |
| project         | id (Integer)      | Retrieves the details of a single Project  |
| skill           | id (Integer)      | Retrieves the details of a single Skill  |

## Query models
#### Company
| Field           | Type              | Description  |
|:----------------|:------------------|:-------------|
| id              | Integer           | The Id of the Company  |
| name            | String            | The name of the Company |
| dateStarted     | DateTime (string) | The year and month employment began at the Company |
| dateLeft        | DateTime (string) | The year and month employment ended at the Company |
| workDescription | String            | What kind of work the employment at the Company entailed |

#### Education
| Field          | Type              | Description  |
|:---------------|:------------------|:-------------|
| id             | Integer           | The Id of the Education  |
| name           | String            | The name of the Education |
| taughtAt       | String            | Where the Education was taken |
| graduationDate | DateTime (string) | The month and year graduation from the Education took place |

#### Project
| Field       | Type             | Description  |
|:------------|:-----------------|:-------------|
| id          | Integer          | The Id of the Project  |
| name        | String           | The name of the Project |
| company     | Company (object) | The company the Project was undertaken for |
| description | String           | What solution the Project sought to provide |

#### Skill
| Field       | Type    | Description  |
|:------------|:--------|:-------------|
| id          | Integer | The Id of the Skill  |
| name        | String  | The name of the Skill |
| proficiency | String  | The proficiency with the Skill, ranging from Low to High |
