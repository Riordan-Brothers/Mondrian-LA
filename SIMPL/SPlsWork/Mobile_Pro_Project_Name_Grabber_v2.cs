using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_MOBILE_PRO_PROJECT_NAME_GRABBER_V2
{
    public class UserModuleClass_MOBILE_PRO_PROJECT_NAME_GRABBER_V2 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput GET_MOBILE_PROJECT_NAME_B;
        Crestron.Logos.SplusObjects.DigitalOutput GET_MOBILE_PROJECT_NAME_BUSY_FB;
        Crestron.Logos.SplusObjects.StringOutput MOBILE_PROJECT_NAME_TXT__DOLLAR__;
        UShortParameter DEBUGMODE;
        UShortParameter PROCESSORMODE;
        StringParameter PROJECTLOCATION__DOLLAR__;
        StringParameter MATCHSEGMENT__DOLLAR__;
        ushort G_NDEBUG = 0;
        CrestronString G_SSEARCHLOCATION__DOLLAR__;
        CrestronString G_SSEARCHLOCATIONALT__DOLLAR__;
        CrestronString G_SMATCHSEGMENT__DOLLAR__;
        CrestronString G_SMANIFESTFILENAME__DOLLAR__;
        CrestronString G_SPREVIOUSMANIFESTFILENAME__DOLLAR__;
        CrestronString [] G_SSPECIALCHARACTERSORIGINAL__DOLLAR__;
        CrestronString [] G_SSPECIALCHARACTERSREPLACE__DOLLAR__;
        private CrestronString FNGETSEARCHLOCATION (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 142;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 142;
                Trace( "***** Start fnGetSearchLocation *****\r\n") ; 
                }
            
            __context__.SourceCodeLine = 144;
            
                {
                int __SPLS_TMPVAR__SWTCH_1__ = ((int)Functions.GetSeries());
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 148;
                        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                            {
                            __context__.SourceCodeLine = 148;
                            Trace( "2 Series Processor\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 149;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (PROJECTLOCATION__DOLLAR__  == "Internal"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 151;
                            Functions.ClearBuffer ( G_SSEARCHLOCATIONALT__DOLLAR__ ) ; 
                            __context__.SourceCodeLine = 152;
                            MakeString ( G_SSEARCHLOCATION__DOLLAR__ , "{0}", "\\html\\" ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 154;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (PROJECTLOCATION__DOLLAR__  == "External"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 156;
                                Functions.ClearBuffer ( G_SSEARCHLOCATIONALT__DOLLAR__ ) ; 
                                __context__.SourceCodeLine = 157;
                                MakeString ( G_SSEARCHLOCATION__DOLLAR__ , "{0}", "\\CF0\\html\\" ) ; 
                                } 
                            
                            }
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 3) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 162;
                        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                            {
                            __context__.SourceCodeLine = 162;
                            Trace( "3 Series Processor\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 163;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (PROJECTLOCATION__DOLLAR__  == "Internal"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 165;
                            Functions.ClearBuffer ( G_SSEARCHLOCATIONALT__DOLLAR__ ) ; 
                            __context__.SourceCodeLine = 166;
                            MakeString ( G_SSEARCHLOCATION__DOLLAR__ , "{0}", "\\html\\" ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 168;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (PROJECTLOCATION__DOLLAR__  == "External"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 170;
                                Functions.ClearBuffer ( G_SSEARCHLOCATIONALT__DOLLAR__ ) ; 
                                __context__.SourceCodeLine = 171;
                                MakeString ( G_SSEARCHLOCATION__DOLLAR__ , "{0}", "\\RM\\html\\" ) ; 
                                } 
                            
                            }
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 4) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 176;
                        if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                            {
                            __context__.SourceCodeLine = 176;
                            Trace( "4 Series Processor\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 177;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (PROJECTLOCATION__DOLLAR__  == "Internal"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 179;
                            Functions.ClearBuffer ( G_SSEARCHLOCATIONALT__DOLLAR__ ) ; 
                            __context__.SourceCodeLine = 180;
                            MakeString ( G_SSEARCHLOCATION__DOLLAR__ , "{0}", "\\html\\" ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 182;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (PROJECTLOCATION__DOLLAR__  == "External"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 184;
                                Functions.ClearBuffer ( G_SSEARCHLOCATIONALT__DOLLAR__ ) ; 
                                __context__.SourceCodeLine = 185;
                                MakeString ( G_SSEARCHLOCATION__DOLLAR__ , "{0}", "\\RM\\html\\" ) ; 
                                } 
                            
                            }
                        
                        } 
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 191;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 191;
                Trace( "g_sSearchLocation$ = {0}\r\n", G_SSEARCHLOCATION__DOLLAR__ ) ; 
                }
            
            __context__.SourceCodeLine = 192;
            return ( G_SSEARCHLOCATION__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 194;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 194;
                Trace( "***** End fnGetSearchLocation *****\r\n") ; 
                }
            
            
            }
            
        private ushort FNREPLACECHARACTERCOUNT (  SplusExecutionContext __context__ ) 
            { 
            ushort NCOUNT = 0;
            
            
            __context__.SourceCodeLine = 201;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)10; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( NCOUNT  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (NCOUNT  >= __FN_FORSTART_VAL__1) && (NCOUNT  <= __FN_FOREND_VAL__1) ) : ( (NCOUNT  <= __FN_FORSTART_VAL__1) && (NCOUNT  >= __FN_FOREND_VAL__1) ) ; NCOUNT  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 203;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SSPECIALCHARACTERSREPLACE__DOLLAR__[ NCOUNT ] == ""))  ) ) 
                    { 
                    __context__.SourceCodeLine = 205;
                    NCOUNT = (ushort) ( (NCOUNT - 1) ) ; 
                    __context__.SourceCodeLine = 206;
                    break ; 
                    } 
                
                __context__.SourceCodeLine = 201;
                } 
            
            __context__.SourceCodeLine = 210;
            return (ushort)( NCOUNT) ; 
            
            }
            
        private ushort FNSPECIALCHARACTERCOUNT (  SplusExecutionContext __context__ ) 
            { 
            ushort NCOUNT = 0;
            
            
            __context__.SourceCodeLine = 217;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)10; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( NCOUNT  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (NCOUNT  >= __FN_FORSTART_VAL__1) && (NCOUNT  <= __FN_FOREND_VAL__1) ) : ( (NCOUNT  <= __FN_FORSTART_VAL__1) && (NCOUNT  >= __FN_FOREND_VAL__1) ) ; NCOUNT  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 219;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SSPECIALCHARACTERSORIGINAL__DOLLAR__[ NCOUNT ] == ""))  ) ) 
                    { 
                    __context__.SourceCodeLine = 221;
                    NCOUNT = (ushort) ( (NCOUNT - 1) ) ; 
                    __context__.SourceCodeLine = 222;
                    break ; 
                    } 
                
                __context__.SourceCodeLine = 217;
                } 
            
            __context__.SourceCodeLine = 226;
            return (ushort)( NCOUNT) ; 
            
            }
            
        private CrestronString FNADDSPECIALCHARACTERS (  SplusExecutionContext __context__, CrestronString SMANIFESTFILENAME__DOLLAR__ ) 
            { 
            ushort NCOUNT = 0;
            ushort NCOUNT2 = 0;
            ushort NREPLACECHARCOUNT = 0;
            
            CrestronString STEMP__DOLLAR__;
            STEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
            
            
            __context__.SourceCodeLine = 234;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 234;
                Trace( "***** Start fnAddSpecialCharacters *****\r\n") ; 
                }
            
            __context__.SourceCodeLine = 236;
            NREPLACECHARCOUNT = (ushort) ( FNREPLACECHARACTERCOUNT( __context__ ) ) ; 
            __context__.SourceCodeLine = 237;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 237;
                Trace( "nReplaceCharCount = {0:d}\r\n", (short)NREPLACECHARCOUNT) ; 
                }
            
            __context__.SourceCodeLine = 238;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 238;
                Trace( "sManifestFileName$ = {0}\r\n", SMANIFESTFILENAME__DOLLAR__ ) ; 
                }
            
            __context__.SourceCodeLine = 239;
            Functions.ClearBuffer ( STEMP__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 241;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)NREPLACECHARCOUNT; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( NCOUNT  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (NCOUNT  >= __FN_FORSTART_VAL__1) && (NCOUNT  <= __FN_FOREND_VAL__1) ) : ( (NCOUNT  <= __FN_FORSTART_VAL__1) && (NCOUNT  >= __FN_FOREND_VAL__1) ) ; NCOUNT  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 243;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 243;
                    Trace( "nCount = {0:d}\r\n", (short)NCOUNT) ; 
                    }
                
                __context__.SourceCodeLine = 244;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 244;
                    Trace( "g_sSpecialCharactersReplace$[nCount] = {0}\r\n", G_SSPECIALCHARACTERSREPLACE__DOLLAR__ [ NCOUNT ] ) ; 
                    }
                
                __context__.SourceCodeLine = 245;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 245;
                    Trace( "find(g_sSpecialCharactersReplace$[nCount], sManifestFileName$) = {0:d}\r\n", (short)Functions.Find( G_SSPECIALCHARACTERSREPLACE__DOLLAR__[ NCOUNT ] , SMANIFESTFILENAME__DOLLAR__ )) ; 
                    }
                
                __context__.SourceCodeLine = 246;
                while ( Functions.TestForTrue  ( ( Functions.Find( G_SSPECIALCHARACTERSREPLACE__DOLLAR__[ NCOUNT ] , SMANIFESTFILENAME__DOLLAR__ ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 248;
                    if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                        {
                        __context__.SourceCodeLine = 248;
                        Trace( "** Inside while(find(g_sSpecialCharactersReplace$[nCount], sManifestFileName$)) **\r\n") ; 
                        }
                    
                    __context__.SourceCodeLine = 249;
                    MakeString ( STEMP__DOLLAR__ , "{0}", Functions.Remove ( G_SSPECIALCHARACTERSREPLACE__DOLLAR__ [ NCOUNT ] , SMANIFESTFILENAME__DOLLAR__ ) ) ; 
                    __context__.SourceCodeLine = 250;
                    NCOUNT2 = (ushort) ( (Functions.Length( STEMP__DOLLAR__ ) - Functions.Length( G_SSPECIALCHARACTERSREPLACE__DOLLAR__[ NCOUNT ] )) ) ; 
                    __context__.SourceCodeLine = 251;
                    MakeString ( SMANIFESTFILENAME__DOLLAR__ , "{0}{1}{2}", Functions.Left ( STEMP__DOLLAR__ ,  (int) ( NCOUNT2 ) ) , G_SSPECIALCHARACTERSORIGINAL__DOLLAR__ [ NCOUNT ] , SMANIFESTFILENAME__DOLLAR__ ) ; 
                    __context__.SourceCodeLine = 252;
                    if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                        {
                        __context__.SourceCodeLine = 252;
                        Trace( "sTemp$ = {0}\r\n", STEMP__DOLLAR__ ) ; 
                        }
                    
                    __context__.SourceCodeLine = 253;
                    if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                        {
                        __context__.SourceCodeLine = 253;
                        Trace( "nCount2 = {0:d}\r\n", (short)NCOUNT) ; 
                        }
                    
                    __context__.SourceCodeLine = 254;
                    if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                        {
                        __context__.SourceCodeLine = 254;
                        Trace( "g_sSpecialCharactersOriginal$[nCount] = ***{0}***\r\n", G_SSPECIALCHARACTERSORIGINAL__DOLLAR__ [ NCOUNT ] ) ; 
                        }
                    
                    __context__.SourceCodeLine = 255;
                    if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                        {
                        __context__.SourceCodeLine = 255;
                        Trace( "sManifestFileName$ = {0}\r\n", SMANIFESTFILENAME__DOLLAR__ ) ; 
                        }
                    
                    __context__.SourceCodeLine = 246;
                    } 
                
                __context__.SourceCodeLine = 241;
                } 
            
            __context__.SourceCodeLine = 259;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 259;
                Trace( "***** End fnAddSpecialCharacters *****\r\n") ; 
                }
            
            __context__.SourceCodeLine = 261;
            return ( SMANIFESTFILENAME__DOLLAR__ ) ; 
            
            }
            
        private CrestronString FNREMOVESPECIALCHARACTERS (  SplusExecutionContext __context__, CrestronString SMANIFESTFILENAME__DOLLAR__ ) 
            { 
            ushort NCOUNT = 0;
            ushort NCOUNT2 = 0;
            ushort NSPECIALCHARCOUNT = 0;
            
            CrestronString STEMP__DOLLAR__;
            STEMP__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
            
            
            __context__.SourceCodeLine = 269;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 269;
                Trace( "***** Start fnRemoveSpecialCharacters *****\r\n") ; 
                }
            
            __context__.SourceCodeLine = 271;
            NSPECIALCHARCOUNT = (ushort) ( FNSPECIALCHARACTERCOUNT( __context__ ) ) ; 
            __context__.SourceCodeLine = 272;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 272;
                Trace( "nSpecialCharCount = {0:d}\r\n", (short)NSPECIALCHARCOUNT) ; 
                }
            
            __context__.SourceCodeLine = 273;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 273;
                Trace( "sManifestFileName$ = {0}\r\n", SMANIFESTFILENAME__DOLLAR__ ) ; 
                }
            
            __context__.SourceCodeLine = 274;
            Functions.ClearBuffer ( STEMP__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 276;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)NSPECIALCHARCOUNT; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( NCOUNT  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (NCOUNT  >= __FN_FORSTART_VAL__1) && (NCOUNT  <= __FN_FOREND_VAL__1) ) : ( (NCOUNT  <= __FN_FORSTART_VAL__1) && (NCOUNT  >= __FN_FOREND_VAL__1) ) ; NCOUNT  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 278;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 278;
                    Trace( "nCount = {0:d}\r\n", (short)NCOUNT) ; 
                    }
                
                __context__.SourceCodeLine = 279;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 279;
                    Trace( "g_sSpecialCharactersOriginal$[nCount] = {0}\r\n", G_SSPECIALCHARACTERSORIGINAL__DOLLAR__ [ NCOUNT ] ) ; 
                    }
                
                __context__.SourceCodeLine = 280;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 280;
                    Trace( "find(g_sSpecialCharactersOriginal$[nCount], sManifestFileName$) = {0:d}\r\n", (short)Functions.Find( G_SSPECIALCHARACTERSORIGINAL__DOLLAR__[ NCOUNT ] , SMANIFESTFILENAME__DOLLAR__ )) ; 
                    }
                
                __context__.SourceCodeLine = 281;
                while ( Functions.TestForTrue  ( ( Functions.Find( G_SSPECIALCHARACTERSORIGINAL__DOLLAR__[ NCOUNT ] , SMANIFESTFILENAME__DOLLAR__ ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 283;
                    if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                        {
                        __context__.SourceCodeLine = 283;
                        Trace( "** Inside while(find(g_sSpecialCharactersOriginal$[nCount], sManifestFileName$)) **\r\n") ; 
                        }
                    
                    __context__.SourceCodeLine = 284;
                    MakeString ( STEMP__DOLLAR__ , "{0}", Functions.Remove ( G_SSPECIALCHARACTERSORIGINAL__DOLLAR__ [ NCOUNT ] , SMANIFESTFILENAME__DOLLAR__ ) ) ; 
                    __context__.SourceCodeLine = 285;
                    NCOUNT2 = (ushort) ( (Functions.Length( STEMP__DOLLAR__ ) - Functions.Length( G_SSPECIALCHARACTERSORIGINAL__DOLLAR__[ NCOUNT ] )) ) ; 
                    __context__.SourceCodeLine = 286;
                    MakeString ( SMANIFESTFILENAME__DOLLAR__ , "{0}{1}{2}", Functions.Left ( STEMP__DOLLAR__ ,  (int) ( NCOUNT2 ) ) , G_SSPECIALCHARACTERSREPLACE__DOLLAR__ [ NCOUNT ] , SMANIFESTFILENAME__DOLLAR__ ) ; 
                    __context__.SourceCodeLine = 287;
                    if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                        {
                        __context__.SourceCodeLine = 287;
                        Trace( "sTemp$ = {0}\r\n", STEMP__DOLLAR__ ) ; 
                        }
                    
                    __context__.SourceCodeLine = 288;
                    if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                        {
                        __context__.SourceCodeLine = 288;
                        Trace( "nCount2 = {0:d}\r\n", (short)NCOUNT) ; 
                        }
                    
                    __context__.SourceCodeLine = 289;
                    if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                        {
                        __context__.SourceCodeLine = 289;
                        Trace( "g_sSpecialCharactersReplace$[nCount] = ***{0}***\r\n", G_SSPECIALCHARACTERSREPLACE__DOLLAR__ [ NCOUNT ] ) ; 
                        }
                    
                    __context__.SourceCodeLine = 290;
                    if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                        {
                        __context__.SourceCodeLine = 290;
                        Trace( "sManifestFileName$ = {0}\r\n", SMANIFESTFILENAME__DOLLAR__ ) ; 
                        }
                    
                    __context__.SourceCodeLine = 281;
                    } 
                
                __context__.SourceCodeLine = 276;
                } 
            
            __context__.SourceCodeLine = 294;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 294;
                Trace( "***** End fnRemoveSpecialCharacters *****\r\n") ; 
                }
            
            __context__.SourceCodeLine = 296;
            return ( SMANIFESTFILENAME__DOLLAR__ ) ; 
            
            }
            
        private CrestronString FNFINDMOBILEPROJECT (  SplusExecutionContext __context__ ) 
            { 
            FILE_INFO FIFILEINFO;
            FIFILEINFO  = new FILE_INFO();
            FIFILEINFO .PopulateDefaults();
            
            ushort NALTLOCATIONFOUND = 0;
            ushort NPOSITION = 0;
            
            short SNMANIFESTFILEFOUND = 0;
            short SNSTARTFILEIOERROR = 0;
            short SNENDFILEIOERROR = 0;
            
            CrestronString SMANIFESTFILENAME__DOLLAR__;
            CrestronString SMANIFESTSEARCHPATH__DOLLAR__;
            CrestronString SMANIFESTSEARCHPATHALT__DOLLAR__;
            SMANIFESTFILENAME__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
            SMANIFESTSEARCHPATH__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 250, this );
            SMANIFESTSEARCHPATHALT__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 250, this );
            
            
            __context__.SourceCodeLine = 306;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 306;
                Trace( "***** Start fnFindMobileProject *****\r\n") ; 
                }
            
            __context__.SourceCodeLine = 308;
            NALTLOCATIONFOUND = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 310;
            FNGETSEARCHLOCATION (  __context__  ) ; 
            __context__.SourceCodeLine = 312;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( G_SMATCHSEGMENT__DOLLAR__ ) > 1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 314;
                MakeString ( SMANIFESTSEARCHPATH__DOLLAR__ , "{0}*{1}{2}", G_SSEARCHLOCATION__DOLLAR__ , G_SMATCHSEGMENT__DOLLAR__ , "*_Manifest.xml" ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 318;
                MakeString ( SMANIFESTSEARCHPATH__DOLLAR__ , "{0}{1}", G_SSEARCHLOCATION__DOLLAR__ , "*_Manifest.xml" ) ; 
                } 
            
            __context__.SourceCodeLine = 320;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SMANIFESTSEARCHPATHALT__DOLLAR__ ) > 1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 322;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( G_SMATCHSEGMENT__DOLLAR__ ) > 1 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 324;
                    MakeString ( SMANIFESTSEARCHPATHALT__DOLLAR__ , "{0}*{1}{2}", G_SSEARCHLOCATIONALT__DOLLAR__ , G_SMATCHSEGMENT__DOLLAR__ , "*_Manifest.xml" ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 328;
                    MakeString ( SMANIFESTSEARCHPATHALT__DOLLAR__ , "{0}{1}", G_SSEARCHLOCATIONALT__DOLLAR__ , "*_Manifest.xml" ) ; 
                    } 
                
                __context__.SourceCodeLine = 330;
                NALTLOCATIONFOUND = (ushort) ( 1 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 334;
                Functions.ClearBuffer ( SMANIFESTSEARCHPATHALT__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 335;
                NALTLOCATIONFOUND = (ushort) ( 0 ) ; 
                } 
            
            __context__.SourceCodeLine = 338;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 338;
                Trace( "sManifestSearchPath$ = {0}\r\n", SMANIFESTSEARCHPATH__DOLLAR__ ) ; 
                }
            
            __context__.SourceCodeLine = 339;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 339;
                Trace( "sManifestSearchPathAlt$ = {0}\r\n", SMANIFESTSEARCHPATHALT__DOLLAR__ ) ; 
                }
            
            __context__.SourceCodeLine = 341;
            MakeString ( SMANIFESTSEARCHPATH__DOLLAR__ , "{0}", FNADDSPECIALCHARACTERS (  __context__ , SMANIFESTSEARCHPATH__DOLLAR__) ) ; 
            __context__.SourceCodeLine = 342;
            MakeString ( SMANIFESTSEARCHPATHALT__DOLLAR__ , "{0}", FNADDSPECIALCHARACTERS (  __context__ , SMANIFESTSEARCHPATHALT__DOLLAR__) ) ; 
            __context__.SourceCodeLine = 344;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 344;
                Trace( "sManifestSearchPath$ = {0}\r\n", SMANIFESTSEARCHPATH__DOLLAR__ ) ; 
                }
            
            __context__.SourceCodeLine = 345;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 345;
                Trace( "sManifestSearchPathAlt$ = {0}\r\n", SMANIFESTSEARCHPATHALT__DOLLAR__ ) ; 
                }
            
            __context__.SourceCodeLine = 347;
            SNSTARTFILEIOERROR = (short) ( StartFileOperations() ) ; 
            __context__.SourceCodeLine = 348;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNSTARTFILEIOERROR != 0))  ) ) 
                { 
                __context__.SourceCodeLine = 350;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 350;
                    Trace( "Start File Operations Error Retrying\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 351;
                Functions.Delay (  (int) ( 100 ) ) ; 
                __context__.SourceCodeLine = 352;
                SNSTARTFILEIOERROR = (short) ( StartFileOperations() ) ; 
                __context__.SourceCodeLine = 348;
                } 
            
            __context__.SourceCodeLine = 355;
            
                {
                int __SPLS_TMPVAR__SWTCH_2__ = ((int)Functions.GetSeries());
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 359;
                        SNMANIFESTFILEFOUND = (short) ( FindFirst( SMANIFESTSEARCHPATH__DOLLAR__ , ref FIFILEINFO ) ) ; 
                        __context__.SourceCodeLine = 360;
                        FindClose ( ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 3) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 364;
                        SNMANIFESTFILEFOUND = (short) ( FindFirstShared( SMANIFESTSEARCHPATH__DOLLAR__ , ref FIFILEINFO ) ) ; 
                        __context__.SourceCodeLine = 365;
                        FindClose ( ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 4) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 369;
                        SNMANIFESTFILEFOUND = (short) ( FindFirstShared( SMANIFESTSEARCHPATH__DOLLAR__ , ref FIFILEINFO ) ) ; 
                        __context__.SourceCodeLine = 370;
                        FindClose ( ) ; 
                        } 
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 375;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 375;
                Trace( "snManifestFileFound = {0:d}\r\n", (short)SNMANIFESTFILEFOUND) ; 
                }
            
            __context__.SourceCodeLine = 377;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNMANIFESTFILEFOUND == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 379;
                MakeString ( SMANIFESTFILENAME__DOLLAR__ , "{0}", FIFILEINFO .  Name ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 381;
                if ( Functions.TestForTrue  ( ( NALTLOCATIONFOUND)  ) ) 
                    { 
                    __context__.SourceCodeLine = 383;
                    
                        {
                        int __SPLS_TMPVAR__SWTCH_3__ = ((int)Functions.GetSeries());
                        
                            { 
                            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 2) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 387;
                                SNMANIFESTFILEFOUND = (short) ( FindFirst( SMANIFESTSEARCHPATHALT__DOLLAR__ , ref FIFILEINFO ) ) ; 
                                __context__.SourceCodeLine = 388;
                                FindClose ( ) ; 
                                } 
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 3) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 392;
                                SNMANIFESTFILEFOUND = (short) ( FindFirstShared( SMANIFESTSEARCHPATHALT__DOLLAR__ , ref FIFILEINFO ) ) ; 
                                __context__.SourceCodeLine = 393;
                                FindClose ( ) ; 
                                } 
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 4) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 397;
                                SNMANIFESTFILEFOUND = (short) ( FindFirstShared( SMANIFESTSEARCHPATHALT__DOLLAR__ , ref FIFILEINFO ) ) ; 
                                __context__.SourceCodeLine = 398;
                                FindClose ( ) ; 
                                } 
                            
                            } 
                            
                        }
                        
                    
                    __context__.SourceCodeLine = 403;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNMANIFESTFILEFOUND == 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 405;
                        MakeString ( SMANIFESTFILENAME__DOLLAR__ , "{0}", FIFILEINFO .  Name ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 409;
                        MakeString ( SMANIFESTFILENAME__DOLLAR__ , "{0}", "Error Finding Project" ) ; 
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 414;
                    MakeString ( SMANIFESTFILENAME__DOLLAR__ , "{0}", "Error Finding Project" ) ; 
                    } 
                
                }
            
            __context__.SourceCodeLine = 416;
            SNENDFILEIOERROR = (short) ( EndFileOperations() ) ; 
            __context__.SourceCodeLine = 417;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNENDFILEIOERROR != 0))  ) ) 
                { 
                __context__.SourceCodeLine = 419;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 419;
                    Trace( "End File Operations Error Retrying\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 420;
                Functions.Delay (  (int) ( 100 ) ) ; 
                __context__.SourceCodeLine = 421;
                SNENDFILEIOERROR = (short) ( EndFileOperations() ) ; 
                __context__.SourceCodeLine = 417;
                } 
            
            __context__.SourceCodeLine = 424;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 424;
                Trace( "sManifestFileName$ = {0}\r\n", SMANIFESTFILENAME__DOLLAR__ ) ; 
                }
            
            __context__.SourceCodeLine = 426;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SMANIFESTFILENAME__DOLLAR__ != "Error Finding Project"))  ) ) 
                { 
                __context__.SourceCodeLine = 428;
                MakeString ( SMANIFESTFILENAME__DOLLAR__ , "{0}", FNREMOVESPECIALCHARACTERS (  __context__ , SMANIFESTFILENAME__DOLLAR__) ) ; 
                __context__.SourceCodeLine = 429;
                NPOSITION = (ushort) ( Functions.Find( "_Manifest.xml" , SMANIFESTFILENAME__DOLLAR__ ) ) ; 
                __context__.SourceCodeLine = 430;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 430;
                    Trace( "sManifestFileName$ = {0}\r\n", SMANIFESTFILENAME__DOLLAR__ ) ; 
                    }
                
                __context__.SourceCodeLine = 431;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 431;
                    Trace( "nPosition = {0:d}\r\n", (short)NPOSITION) ; 
                    }
                
                __context__.SourceCodeLine = 433;
                if ( Functions.TestForTrue  ( ( NPOSITION)  ) ) 
                    { 
                    __context__.SourceCodeLine = 435;
                    MakeString ( SMANIFESTFILENAME__DOLLAR__ , "{0}", Functions.Left ( SMANIFESTFILENAME__DOLLAR__ ,  (int) ( (NPOSITION - 1) ) ) ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 439;
            return ( SMANIFESTFILENAME__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 441;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 441;
                Trace( "***** End fnFindMobileProject *****\r\n") ; 
                }
            
            
            }
            
        private void FNGETMOBILEPROJECTNAME (  SplusExecutionContext __context__ ) 
            { 
            CrestronString SMANIFESTFILENAME__DOLLAR__;
            SMANIFESTFILENAME__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
            
            
            __context__.SourceCodeLine = 448;
            if ( Functions.TestForTrue  ( ( Functions.Not( GET_MOBILE_PROJECT_NAME_BUSY_FB  .Value ))  ) ) 
                { 
                __context__.SourceCodeLine = 450;
                GET_MOBILE_PROJECT_NAME_BUSY_FB  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 451;
                if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 451;
                    Trace( "Inside if(!Get_Mobile_Project_Name_Busy_fb)\r\n") ; 
                    }
                
                __context__.SourceCodeLine = 453;
                MakeString ( SMANIFESTFILENAME__DOLLAR__ , "{0}", FNFINDMOBILEPROJECT (  __context__  ) ) ; 
                __context__.SourceCodeLine = 454;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SMANIFESTFILENAME__DOLLAR__ != G_SPREVIOUSMANIFESTFILENAME__DOLLAR__))  ) ) 
                    { 
                    __context__.SourceCodeLine = 456;
                    MakeString ( MOBILE_PROJECT_NAME_TXT__DOLLAR__ , "{0}", SMANIFESTFILENAME__DOLLAR__ ) ; 
                    __context__.SourceCodeLine = 457;
                    MakeString ( G_SPREVIOUSMANIFESTFILENAME__DOLLAR__ , "{0}", SMANIFESTFILENAME__DOLLAR__ ) ; 
                    } 
                
                __context__.SourceCodeLine = 459;
                GET_MOBILE_PROJECT_NAME_BUSY_FB  .Value = (ushort) ( 0 ) ; 
                } 
            
            
            }
            
        object GET_MOBILE_PROJECT_NAME_B_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 468;
                FNGETMOBILEPROJECTNAME (  __context__  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    public override object FunctionMain (  object __obj__ ) 
        { 
        ushort NCOUNT = 0;
        
        try
        {
            SplusExecutionContext __context__ = SplusFunctionMainStartCode();
            
            __context__.SourceCodeLine = 478;
            WaitForInitializationComplete ( ) ; 
            __context__.SourceCodeLine = 480;
            G_NDEBUG = (ushort) ( DEBUGMODE  .Value ) ; 
            __context__.SourceCodeLine = 481;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 481;
                Trace( "***** Start Function Main *****\r\n") ; 
                }
            
            __context__.SourceCodeLine = 483;
            Functions.ClearBuffer ( G_SSEARCHLOCATION__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 484;
            Functions.ClearBuffer ( G_SSEARCHLOCATIONALT__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 485;
            Functions.ClearBuffer ( G_SPREVIOUSMANIFESTFILENAME__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 487;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( MATCHSEGMENT__DOLLAR__  ) > 1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 489;
                MakeString ( G_SMATCHSEGMENT__DOLLAR__ , "{0}", MATCHSEGMENT__DOLLAR__ ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 493;
                Functions.ClearBuffer ( G_SMATCHSEGMENT__DOLLAR__ ) ; 
                } 
            
            __context__.SourceCodeLine = 496;
            MakeString ( G_SSPECIALCHARACTERSORIGINAL__DOLLAR__ [ 1 ] , "{0}", "_20" ) ; 
            __context__.SourceCodeLine = 497;
            MakeString ( G_SSPECIALCHARACTERSORIGINAL__DOLLAR__ [ 2 ] , "{0}", "" ) ; 
            __context__.SourceCodeLine = 498;
            MakeString ( G_SSPECIALCHARACTERSORIGINAL__DOLLAR__ [ 3 ] , "{0}", "" ) ; 
            __context__.SourceCodeLine = 499;
            MakeString ( G_SSPECIALCHARACTERSORIGINAL__DOLLAR__ [ 4 ] , "{0}", "" ) ; 
            __context__.SourceCodeLine = 500;
            MakeString ( G_SSPECIALCHARACTERSORIGINAL__DOLLAR__ [ 5 ] , "{0}", "" ) ; 
            __context__.SourceCodeLine = 501;
            MakeString ( G_SSPECIALCHARACTERSORIGINAL__DOLLAR__ [ 6 ] , "{0}", "" ) ; 
            __context__.SourceCodeLine = 502;
            MakeString ( G_SSPECIALCHARACTERSORIGINAL__DOLLAR__ [ 7 ] , "{0}", "" ) ; 
            __context__.SourceCodeLine = 503;
            MakeString ( G_SSPECIALCHARACTERSORIGINAL__DOLLAR__ [ 8 ] , "{0}", "" ) ; 
            __context__.SourceCodeLine = 504;
            MakeString ( G_SSPECIALCHARACTERSORIGINAL__DOLLAR__ [ 9 ] , "{0}", "" ) ; 
            __context__.SourceCodeLine = 505;
            MakeString ( G_SSPECIALCHARACTERSORIGINAL__DOLLAR__ [ 10 ] , "{0}", "" ) ; 
            __context__.SourceCodeLine = 507;
            MakeString ( G_SSPECIALCHARACTERSREPLACE__DOLLAR__ [ 1 ] , "{0}", " " ) ; 
            __context__.SourceCodeLine = 508;
            MakeString ( G_SSPECIALCHARACTERSREPLACE__DOLLAR__ [ 2 ] , "{0}", "" ) ; 
            __context__.SourceCodeLine = 509;
            MakeString ( G_SSPECIALCHARACTERSREPLACE__DOLLAR__ [ 3 ] , "{0}", "" ) ; 
            __context__.SourceCodeLine = 510;
            MakeString ( G_SSPECIALCHARACTERSREPLACE__DOLLAR__ [ 4 ] , "{0}", "" ) ; 
            __context__.SourceCodeLine = 511;
            MakeString ( G_SSPECIALCHARACTERSREPLACE__DOLLAR__ [ 5 ] , "{0}", "" ) ; 
            __context__.SourceCodeLine = 512;
            MakeString ( G_SSPECIALCHARACTERSREPLACE__DOLLAR__ [ 6 ] , "{0}", "" ) ; 
            __context__.SourceCodeLine = 513;
            MakeString ( G_SSPECIALCHARACTERSREPLACE__DOLLAR__ [ 7 ] , "{0}", "" ) ; 
            __context__.SourceCodeLine = 514;
            MakeString ( G_SSPECIALCHARACTERSREPLACE__DOLLAR__ [ 8 ] , "{0}", "" ) ; 
            __context__.SourceCodeLine = 515;
            MakeString ( G_SSPECIALCHARACTERSREPLACE__DOLLAR__ [ 9 ] , "{0}", "" ) ; 
            __context__.SourceCodeLine = 516;
            MakeString ( G_SSPECIALCHARACTERSREPLACE__DOLLAR__ [ 10 ] , "{0}", "" ) ; 
            __context__.SourceCodeLine = 518;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 518;
                Trace( "***** Function Main Complete Variable Init *****\r\n") ; 
                }
            
            __context__.SourceCodeLine = 520;
            if ( Functions.TestForTrue  ( ( PROCESSORMODE  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 522;
                Functions.Delay (  (int) ( 12000 ) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 526;
                Functions.Delay (  (int) ( 2000 ) ) ; 
                } 
            
            __context__.SourceCodeLine = 529;
            FNGETMOBILEPROJECTNAME (  __context__  ) ; 
            __context__.SourceCodeLine = 531;
            if ( Functions.TestForTrue  ( ( G_NDEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 531;
                Trace( "***** End Function Main *****\r\n") ; 
                }
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        return __obj__;
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        G_SSEARCHLOCATION__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
        G_SSEARCHLOCATIONALT__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
        G_SMATCHSEGMENT__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
        G_SMANIFESTFILENAME__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
        G_SPREVIOUSMANIFESTFILENAME__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
        G_SSPECIALCHARACTERSORIGINAL__DOLLAR__  = new CrestronString[ 11 ];
        for( uint i = 0; i < 11; i++ )
            G_SSPECIALCHARACTERSORIGINAL__DOLLAR__ [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
        G_SSPECIALCHARACTERSREPLACE__DOLLAR__  = new CrestronString[ 11 ];
        for( uint i = 0; i < 11; i++ )
            G_SSPECIALCHARACTERSREPLACE__DOLLAR__ [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
        
        GET_MOBILE_PROJECT_NAME_B = new Crestron.Logos.SplusObjects.DigitalInput( GET_MOBILE_PROJECT_NAME_B__DigitalInput__, this );
        m_DigitalInputList.Add( GET_MOBILE_PROJECT_NAME_B__DigitalInput__, GET_MOBILE_PROJECT_NAME_B );
        
        GET_MOBILE_PROJECT_NAME_BUSY_FB = new Crestron.Logos.SplusObjects.DigitalOutput( GET_MOBILE_PROJECT_NAME_BUSY_FB__DigitalOutput__, this );
        m_DigitalOutputList.Add( GET_MOBILE_PROJECT_NAME_BUSY_FB__DigitalOutput__, GET_MOBILE_PROJECT_NAME_BUSY_FB );
        
        MOBILE_PROJECT_NAME_TXT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( MOBILE_PROJECT_NAME_TXT__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( MOBILE_PROJECT_NAME_TXT__DOLLAR____AnalogSerialOutput__, MOBILE_PROJECT_NAME_TXT__DOLLAR__ );
        
        DEBUGMODE = new UShortParameter( DEBUGMODE__Parameter__, this );
        m_ParameterList.Add( DEBUGMODE__Parameter__, DEBUGMODE );
        
        PROCESSORMODE = new UShortParameter( PROCESSORMODE__Parameter__, this );
        m_ParameterList.Add( PROCESSORMODE__Parameter__, PROCESSORMODE );
        
        PROJECTLOCATION__DOLLAR__ = new StringParameter( PROJECTLOCATION__DOLLAR____Parameter__, this );
        m_ParameterList.Add( PROJECTLOCATION__DOLLAR____Parameter__, PROJECTLOCATION__DOLLAR__ );
        
        MATCHSEGMENT__DOLLAR__ = new StringParameter( MATCHSEGMENT__DOLLAR____Parameter__, this );
        m_ParameterList.Add( MATCHSEGMENT__DOLLAR____Parameter__, MATCHSEGMENT__DOLLAR__ );
        
        
        GET_MOBILE_PROJECT_NAME_B.OnDigitalPush.Add( new InputChangeHandlerWrapper( GET_MOBILE_PROJECT_NAME_B_OnPush_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_MOBILE_PRO_PROJECT_NAME_GRABBER_V2 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint GET_MOBILE_PROJECT_NAME_B__DigitalInput__ = 0;
    const uint GET_MOBILE_PROJECT_NAME_BUSY_FB__DigitalOutput__ = 0;
    const uint MOBILE_PROJECT_NAME_TXT__DOLLAR____AnalogSerialOutput__ = 0;
    const uint DEBUGMODE__Parameter__ = 10;
    const uint PROCESSORMODE__Parameter__ = 11;
    const uint PROJECTLOCATION__DOLLAR____Parameter__ = 12;
    const uint MATCHSEGMENT__DOLLAR____Parameter__ = 13;
    
    [SplusStructAttribute(-1, true, false)]
    public class SplusNVRAM : SplusStructureBase
    {
    
        public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
        
        
    }
    
    SplusNVRAM _SplusNVRAM = null;
    
    public class __CEvent__ : CEvent
    {
        public __CEvent__() {}
        public void Close() { base.Close(); }
        public int Reset() { return base.Reset() ? 1 : 0; }
        public int Set() { return base.Set() ? 1 : 0; }
        public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
    }
    public class __CMutex__ : CMutex
    {
        public __CMutex__() {}
        public void Close() { base.Close(); }
        public void ReleaseMutex() { base.ReleaseMutex(); }
        public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
    }
     public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
