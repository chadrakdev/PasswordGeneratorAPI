# Password Generator API
A REST API for generating secure passwords and validating password security, with built-in functionality for passing parameters to enable password criteria customisation.

## Endpoints
### Generate
`Example POST Request`
```shell
curl -X POST https://localhost:7128/api/password/generate \
  -H "Content-Type: application/json" \
  -d '{
    "minLength": 8,
    "maxLength": 12,
    "isMixedCase": true,
    "isAlphanumeric": true,
    "includeSpecialCharacters": false
  }' -k
```

`Expected Response (Success)`
```json
{
  "status": 200,
  "data": {
    "response": "generated_password_string",
    "criteria": {
      "minLength": 8,
      "maxLength": 12,
      "isMixedCase": true,
      "isAlphanumeric": true,
      "includeSpecialCharacters": false
    }
  }
}
```

`Expected Response (Error)`
```json
{
  "status": 400,
  "data": null,
  "error": "Invalid password length range."
}
```
If the maxLength is less than minLength or minLength is less than 1, the API will return a 400 Bad Request error with the message: “Invalid password length range.”
<br/>

## Project Structure

### Models
`PasswordCriteria` represents the data structure and logic for the criteria that the password must adhere to

`PasswordReponse` represents the structure of the response in its entirety and holds the response status

`PasswordResponseData` represents the structure of the data object within the response
<br/>

### Controllers
`PasswordController` handles incoming HTTP requests and delegates processing
<br/>

### Services
`PasswordGeneratorService` encapsulates the business logic for improved separation of concerns
<br/>

### Future update(s)
- Introduce human-friendly password criteria option
  - Program will pull in a Dictionary of words to generate human-friendly passwords with randomised word combinations
- Strength validity measure
- Encryption support for sensitive data handling by encryption using RSA to be able to include both a plaintext and encrypted version