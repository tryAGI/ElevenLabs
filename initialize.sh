dotnet tool install --global autosdk.cli --prerelease

autosdk init \
  SolutionName \
  SomeClient \
  https://raw.githubusercontent.com/api/openapi.json \
  CompanyName \
  --output .
