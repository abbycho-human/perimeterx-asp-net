
namespace PerimeterX.DataContracts.Activities
{
    public class ActivitiesUtils
    {
        public static void addCustomParamsToAsyncActivities(ActivityDetails activityDetails, CustomParameters customParameters)
        {
            activityDetails.customParam1 = customParameters.custom_param1;
            activityDetails.customParam2 = customParameters.custom_param2;
            activityDetails.customParam3 = customParameters.custom_param3;
            activityDetails.customParam4 = customParameters.custom_param4;
            activityDetails.customParam5 = customParameters.custom_param5;
            activityDetails.customParam6 = customParameters.custom_param6;
            activityDetails.custom_param7 = customParameters.custom_param7;
            activityDetails.customParam8 = customParameters.custom_param8;
            activityDetails.customParam9 = customParameters.custom_param9;
            activityDetails.customParam10 = customParameters.custom_param10;
        }

        public static void addCustomParamsToRisk(Additional riskActivityDetails, CustomParameters customParameters)
        {
            riskActivityDetails.customParam1 = customParameters.custom_param1;
            riskActivityDetails.customParam2 = customParameters.custom_param2;
            riskActivityDetails.customParam3 = customParameters.custom_param3;
            riskActivityDetails.customParam4 = customParameters.custom_param4;
            riskActivityDetails.customParam5 = customParameters.custom_param5;
            riskActivityDetails.customParam6 = customParameters.custom_param6;
            riskActivityDetails.custom_param7 = customParameters.custom_param7;
            riskActivityDetails.customParam8 = customParameters.custom_param8;
            riskActivityDetails.customParam9 = customParameters.custom_param9;
            riskActivityDetails.customParam10 = customParameters.custom_param10;
        }
    }
}
