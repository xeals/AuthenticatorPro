using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AuthenticatorPro.Shared.Data
{
    public static class Icon
    {
        public const string Default = "default";

        public static readonly Dictionary<string, int> Service = new Dictionary<string, int> 
        {
            // Brand icons
            {"500px", Resource.Drawable.auth_500px},
            {"1and1", Resource.Drawable.auth_1and1},
            {"1password", Resource.Drawable.auth_1password},
            {"23andme", Resource.Drawable.auth_23andme},
            {"3cx", Resource.Drawable.auth_3cx},
            {"a2hosting", Resource.Drawable.auth_a2hosting},
            {"adafruit", Resource.Drawable.auth_adafruit},
            {"adguard", Resource.Drawable.auth_adguard},
            {"adobe", Resource.Drawable.auth_adobe},
            {"airtable", Resource.Drawable.auth_airtable},
            {"algolia", Resource.Drawable.auth_algolia},
            {"allinkl", Resource.Drawable.auth_allinkl},
            {"altaro", Resource.Drawable.auth_altaro},
            {"amazon", Resource.Drawable.auth_amazon},
            {"anycoindirect", Resource.Drawable.auth_anycoindirect},
            {"anydesk", Resource.Drawable.auth_anydesk},
            {"appveyor", Resource.Drawable.auth_appveyor},
            {"arubacloud", Resource.Drawable.auth_arubacloud},
            {"atlassian", Resource.Drawable.auth_atlassian},
            {"autodesk", Resource.Drawable.auth_autodesk},
            {"awardwallet", Resource.Drawable.auth_awardwallet},
            {"aws", Resource.Drawable.auth_aws},
            {"azure", Resource.Drawable.auth_azure},
            {"backblaze", Resource.Drawable.auth_backblaze},
            {"binance", Resource.Drawable.auth_binance},
            {"bitbucket", Resource.Drawable.auth_bitbucket},
            {"bitcoin", Resource.Drawable.auth_bitcoin},
            {"bitdefener", Resource.Drawable.auth_bitdefender},
            {"bitfinex", Resource.Drawable.auth_bitfinex},
            {"bitpay", Resource.Drawable.auth_bitpay},
            {"bitwarden", Resource.Drawable.auth_bitwarden},
            {"blizzard", Resource.Drawable.auth_blizzard},
            {"blockchain", Resource.Drawable.auth_blockchain},
            {"bluehost", Resource.Drawable.auth_bluehost},
            {"borgbase", Resource.Drawable.auth_borgbase},
            {"boxcryptor", Resource.Drawable.auth_boxcryptor},
            {"cachet", Resource.Drawable.auth_cachet},
            {"cexio", Resource.Drawable.auth_cexio},
            {"chargebee", Resource.Drawable.auth_chargebee},
            {"charliehr", Resource.Drawable.auth_charliehr},
            {"cloudflare", Resource.Drawable.auth_cloudflare},
            {"cloudways", Resource.Drawable.auth_cloudways},
            {"codeship", Resource.Drawable.auth_codeship},
            {"coinbase", Resource.Drawable.auth_coinbase},
            {"confluence", Resource.Drawable.auth_confluence},
            {"contabo", Resource.Drawable.auth_contabo},
            {"crowdin", Resource.Drawable.auth_crowdin},
            {"dashlane", Resource.Drawable.auth_dashlane},
            {"digitalocean", Resource.Drawable.auth_digitalocean},
            {"directadmin", Resource.Drawable.auth_directadmin},
            {"discord", Resource.Drawable.auth_discord},
            {"docker", Resource.Drawable.auth_docker},
            {"dreamhost", Resource.Drawable.auth_dreamhost},
            {"dropbox", Resource.Drawable.auth_dropbox},
            {"drupal", Resource.Drawable.auth_drupal},
            {"electronicarts", Resource.Drawable.auth_electronicarts},
            {"envato", Resource.Drawable.auth_envato},
            {"epicgames", Resource.Drawable.auth_epicgames},
            {"etsy", Resource.Drawable.auth_etsy},
            {"eveonline", Resource.Drawable.auth_eveonline},
            {"evernote", Resource.Drawable.auth_evernote},
            {"facebook", Resource.Drawable.auth_facebook},
            {"fanatical", Resource.Drawable.auth_fanatical},
            {"figma", Resource.Drawable.auth_figma},
            {"firefox", Resource.Drawable.auth_firefox},
            {"funio", Resource.Drawable.auth_funio},
            {"gandi", Resource.Drawable.auth_gandi},
            {"github", Resource.Drawable.auth_github},
            {"gitlab", Resource.Drawable.auth_gitlab},
            {"gmail", Resource.Drawable.auth_gmail},
            {"gmxnet", Resource.Drawable.auth_gmxnet},
            {"godaddy", Resource.Drawable.auth_godaddy},
            {"google", Resource.Drawable.auth_google},
            {"googlecloudplatform", Resource.Drawable.auth_googlecloudplatform},
            {"googledrive", Resource.Drawable.auth_googledrive},
            {"googleplay", Resource.Drawable.auth_googleplay},
            {"grammarly", Resource.Drawable.auth_grammarly},
            {"guildwars2", Resource.Drawable.auth_guildwars2},
            {"hangouts", Resource.Drawable.auth_hangouts},
            {"heroku", Resource.Drawable.auth_heroku},
            {"hetzner", Resource.Drawable.auth_hetzner},
            {"hosteurope", Resource.Drawable.auth_hosteurope},
            {"hover", Resource.Drawable.auth_hover},
            {"humblebundle", Resource.Drawable.auth_humblebundle},
            {"hushmail", Resource.Drawable.auth_hushmail},
            {"ifttt", Resource.Drawable.auth_ifttt},
            {"immobilienscout24", Resource.Drawable.auth_immobilienscout24},
            {"instagram", Resource.Drawable.auth_instagram},
            {"integromat", Resource.Drawable.auth_integromat},
            {"inwx", Resource.Drawable.auth_inwx},
            {"jetbrains", Resource.Drawable.auth_jetbrains},
            {"jetbrains2", Resource.Drawable.auth_jetbrains2 },
            {"jira", Resource.Drawable.auth_jira},
            {"jiraservicedesk", Resource.Drawable.auth_jiraservicedesk},
            {"jottacloud", Resource.Drawable.auth_jottacloud},
            {"keeper", Resource.Drawable.auth_keeper},
            {"kickstarter", Resource.Drawable.auth_kickstarter},
            {"kraken", Resource.Drawable.auth_kraken},
            {"lastpass", Resource.Drawable.auth_lastpass},
            {"leaseweb", Resource.Drawable.auth_leaseweb},
            {"linkedin", Resource.Drawable.auth_linkedin},
            {"linode", Resource.Drawable.auth_linode},
            {"logmein", Resource.Drawable.auth_logmein},
            {"mailboxorg", Resource.Drawable.auth_mailboxorg},
            {"mailchimp", Resource.Drawable.auth_mailchimp},
            {"mailde", Resource.Drawable.auth_mailde},
            {"mailgun", Resource.Drawable.auth_mailgun},
            {"mapbox", Resource.Drawable.auth_mapbox},
            {"mastodon", Resource.Drawable.auth_mastodon},
            {"mega", Resource.Drawable.auth_mega},
            {"microsoft", Resource.Drawable.auth_microsoft},
            {"migadu", Resource.Drawable.auth_migadu},
            {"myheritage", Resource.Drawable.auth_myheritage},
            {"namecheap", Resource.Drawable.auth_namecheap},
            {"namecom", Resource.Drawable.auth_namecom},
            {"namesilo", Resource.Drawable.auth_namesilo},
            {"netcup", Resource.Drawable.auth_netcup},
            {"newegg", Resource.Drawable.auth_newegg},
            {"nextcloud", Resource.Drawable.auth_nextcloud},
            {"nexusmods", Resource.Drawable.auth_nexusmods},
            {"nintendo", Resource.Drawable.auth_nintendo},
            {"nitrado", Resource.Drawable.auth_nitrado},
            {"nominet", Resource.Drawable.auth_nominet},
            {"npm", Resource.Drawable.auth_npm},
            {"office365", Resource.Drawable.auth_office365},
            {"onedrive", Resource.Drawable.auth_onedrive},
            {"onshape", Resource.Drawable.auth_onshape},
            {"opera", Resource.Drawable.auth_opera},
            {"opsgenie", Resource.Drawable.auth_opsgenie},
            {"origin", Resource.Drawable.auth_origin},
            {"outlook", Resource.Drawable.auth_outlook},
            {"ovh", Resource.Drawable.auth_ovh},
            {"parsec", Resource.Drawable.auth_parsec},
            {"patreon", Resource.Drawable.auth_patreon},
            {"paypal", Resource.Drawable.auth_paypal},
            {"playstation", Resource.Drawable.auth_playstation},
            {"pluralsight", Resource.Drawable.auth_pluralsight},
            {"porkbun", Resource.Drawable.auth_porkbun},
            {"posteo", Resource.Drawable.auth_posteo},
            {"privacy", Resource.Drawable.auth_privacy},
            {"privateinternetaccess", Resource.Drawable.auth_privateinternetaccess},
            {"protonmail", Resource.Drawable.auth_protonmail},
            {"protonvpn", Resource.Drawable.auth_protonvpn},
            {"proxmox", Resource.Drawable.auth_proxmox},
            {"pushover", Resource.Drawable.auth_pushover},
            {"pypi", Resource.Drawable.auth_pypi},
            {"rackspace", Resource.Drawable.auth_rackspace},
            {"realvnc", Resource.Drawable.auth_realvnc},
            {"reddit", Resource.Drawable.auth_reddit},
            {"roboform", Resource.Drawable.auth_roboform},
            {"rockstargames", Resource.Drawable.auth_rockstargames},
            {"runcloud", Resource.Drawable.auth_runcloud},
            {"salesforce", Resource.Drawable.auth_salesforce},
            {"samsung", Resource.Drawable.auth_samsung},
            {"samsung2", Resource.Drawable.auth_samsung2},
            {"scaleway", Resource.Drawable.auth_scaleway},
            {"sentry", Resource.Drawable.auth_sentry},
            {"shopify", Resource.Drawable.auth_shopify},
            {"skype", Resource.Drawable.auth_skype},
            {"slack", Resource.Drawable.auth_slack},
            {"snapchat", Resource.Drawable.auth_snapchat},
            {"solarwinds", Resource.Drawable.auth_solarwinds},
            {"square", Resource.Drawable.auth_square},
            {"statuspage", Resource.Drawable.auth_statuspage},
            {"stripe", Resource.Drawable.auth_stripe},
            {"synology", Resource.Drawable.auth_synology},
            {"teamviewer", Resource.Drawable.auth_teamviewer},
            {"time4vps", Resource.Drawable.auth_time4vps},
            {"torguard", Resource.Drawable.auth_torguard},
            {"trello", Resource.Drawable.auth_trello},
            {"tutanota", Resource.Drawable.auth_tutanota},
            {"twitch", Resource.Drawable.auth_twitch},
            {"twitter", Resource.Drawable.auth_twitter},
            {"uber", Resource.Drawable.auth_uber},
            {"ubisoft", Resource.Drawable.auth_ubisoft},
            {"uniteddomains", Resource.Drawable.auth_uniteddomains},
            {"unity", Resource.Drawable.auth_unity },
            {"unlockbase", Resource.Drawable.auth_unlockbase},
            {"uphold", Resource.Drawable.auth_uphold},
            {"uplay", Resource.Drawable.auth_uplay},
            {"uptimerobot", Resource.Drawable.auth_uptimerobot},
            {"visualstudioonline", Resource.Drawable.auth_visualstudioonline},
            {"vultr", Resource.Drawable.auth_vultr},
            {"wargaming", Resource.Drawable.auth_wargaming},
            {"wasabi", Resource.Drawable.auth_wasabi},
            {"webde", Resource.Drawable.auth_webde},
            {"wetransfer", Resource.Drawable.auth_wetransfer},
            {"wikipedia", Resource.Drawable.auth_wikipedia},
            {"wordpress", Resource.Drawable.auth_wordpress},
            {"wpengine", Resource.Drawable.auth_wpengine},
            {"xbox", Resource.Drawable.auth_xbox},
            {"xing", Resource.Drawable.auth_xing},
            {"yandexmail", Resource.Drawable.auth_yandexmail},
            {"ynab", Resource.Drawable.auth_ynab},
            {"youtube", Resource.Drawable.auth_youtube},
            {"zapier", Resource.Drawable.auth_zapier},
            {"zendesk", Resource.Drawable.auth_zendesk},
            {"zohomail", Resource.Drawable.auth_zohomail},
            {"zyxel", Resource.Drawable.auth_zyxel},
                       
            // Generic icons
            {"banking", Resource.Drawable.auth_banking},
            {"cloud", Resource.Drawable.auth_cloud},
            {"desktop", Resource.Drawable.auth_desktop},
            {"dev", Resource.Drawable.auth_dev},
            {"domain", Resource.Drawable.auth_domain},
            {"email", Resource.Drawable.auth_email},
            {"gaming", Resource.Drawable.auth_gaming},
            {"laptop", Resource.Drawable.auth_laptop},
            {"messaging", Resource.Drawable.auth_messaging},
            {"mobile", Resource.Drawable.auth_mobile},
            {"money", Resource.Drawable.auth_money},
            {"money2", Resource.Drawable.auth_money2},
            {"payment", Resource.Drawable.auth_payment},
            {"security", Resource.Drawable.auth_security},
            {"shopping", Resource.Drawable.auth_shopping},
            {"storage", Resource.Drawable.auth_storage},
            {"web", Resource.Drawable.auth_web},
            
            {Default, Resource.Drawable.auth_default}
        };

        private static readonly Dictionary<string, int> ServiceDark = new Dictionary<string, int>
        {
            // Brand icons
            {"500px", Resource.Drawable.auth_500px_dark},
            {"3cx", Resource.Drawable.auth_3cx_dark},
            {"adafruit", Resource.Drawable.auth_adafruit_dark},
            {"adobe", Resource.Drawable.auth_adobe_dark},
            {"anycoindirect", Resource.Drawable.auth_anycoindirect_dark},
            {"amazon", Resource.Drawable.auth_amazon_dark},
            {"borgbase", Resource.Drawable.auth_borgbase_dark},
            {"cloudways", Resource.Drawable.auth_cloudways_dark},
            {"dashlane", Resource.Drawable.auth_dashlane_dark},
            {"electronicarts", Resource.Drawable.auth_electronicarts_dark},
            {"eveonline", Resource.Drawable.auth_eveonline_dark},
            {"github", Resource.Drawable.auth_github_dark},
            {"hushmail", Resource.Drawable.auth_hushmail_dark},
            {"ifttt", Resource.Drawable.auth_ifttt_dark},
            {"jetbrains2", Resource.Drawable.auth_jetbrains2_dark},
            {"netcup", Resource.Drawable.auth_netcup_dark},
            {"patreon", Resource.Drawable.auth_patreon_dark},
            {"runcloud", Resource.Drawable.auth_runcloud_dark},
            {"samsung2", Resource.Drawable.auth_samsung2_dark},
            {"sentry", Resource.Drawable.auth_sentry_dark},
            {"square", Resource.Drawable.auth_square_dark},
            {"synology", Resource.Drawable.auth_synology_dark},
            {"torguard", Resource.Drawable.auth_torguard_dark},
            {"uber", Resource.Drawable.auth_uber_dark},
            {"unity", Resource.Drawable.auth_unity_dark},
            {"ubisoft", Resource.Drawable.auth_ubisoft_dark},
            {"wetransfer", Resource.Drawable.auth_wetransfer_dark},
            {"wordpress", Resource.Drawable.auth_wordpress_dark},
            {"xbox", Resource.Drawable.auth_xbox_dark},
            {"zendesk", Resource.Drawable.auth_zendesk_dark},
            {"zyxel", Resource.Drawable.auth_zyxel_dark},

            // Generic icons
            {"banking", Resource.Drawable.auth_banking_dark},
            {"cloud", Resource.Drawable.auth_cloud_dark},
            {"desktop", Resource.Drawable.auth_desktop_dark},
            {"dev", Resource.Drawable.auth_dev_dark},
            {"domain", Resource.Drawable.auth_domain_dark},
            {"email", Resource.Drawable.auth_email_dark},
            {"gaming", Resource.Drawable.auth_gaming_dark},
            {"laptop", Resource.Drawable.auth_laptop_dark},
            {"messaging", Resource.Drawable.auth_messaging_dark},
            {"mobile", Resource.Drawable.auth_mobile_dark},
            {"money", Resource.Drawable.auth_money_dark},
            {"money2", Resource.Drawable.auth_money2_dark},
            {"payment", Resource.Drawable.auth_payment_dark},
            {"security", Resource.Drawable.auth_security_dark},
            {"shopping", Resource.Drawable.auth_shopping_dark},
            {"storage", Resource.Drawable.auth_storage_dark},
            {"web", Resource.Drawable.auth_web_dark},
            
            {Default, Resource.Drawable.auth_default_dark}
        };

        public static int GetService(string key, bool isDark)
        {
            if(isDark)
            {
                if(key == null)
                    return ServiceDark[Default];

                if(ServiceDark.ContainsKey(key))
                    return ServiceDark[key];

                return Service.ContainsKey(key) ? Service[key] : ServiceDark[Default];
            }

            if(key == null)
                return Service[Default];

            return Service.ContainsKey(key) ? Service[key] : Service[Default];
        }

        public static string FindServiceKeyByName(string name)
        {
            static string Simplify(string input)
            {
                input = input.ToLower();
                input = Regex.Replace(input, @"[^a-z0-9]", "");
                return input.Trim();
            }

            var key = Simplify(name);

            if(Service.ContainsKey(key))
                return key;

            var firstWordKey = Simplify(name.Split(' ', 2)[0]);
            
            return Service.ContainsKey(firstWordKey)
                ? firstWordKey
                : Default;
        }
    }
}
