using UnityEngine;
using UnityEngine.Monetization;

public class ShowAds : MonoBehaviour {

    private const string ADID = "3319906";
    private const string VIDEOID = "video";

    private static int countRestarts;

    private void Start() {
        Monetization.Initialize(ADID, true);

        if (countRestarts != 0 && countRestarts % 3 == 0)
            showAd();

        countRestarts++;
    }

    void showAd() {
        if(Monetization.IsReady(VIDEOID)) {
            ShowAdPlacementContent ad = null;
            ad = Monetization.GetPlacementContent(VIDEOID) as ShowAdPlacementContent;
            if (ad != null)
                ad.Show();
        }
    }

}
