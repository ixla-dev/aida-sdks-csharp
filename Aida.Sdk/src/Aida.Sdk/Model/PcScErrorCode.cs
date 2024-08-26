/*
 * aida
 *
 * 1.0.703.4
 *
 * The version of the OpenAPI document: 1.0.703.4
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = Aida.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Model
{
    /// <summary>
    /// Defines PcScErrorCode
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PcScErrorCode
    {
        /// <summary>
        /// Enum SCARDSSUCCESS for value: SCARD_S_SUCCESS
        /// </summary>
        [EnumMember(Value = "SCARD_S_SUCCESS")]
        SCARDSSUCCESS = 1,

        /// <summary>
        /// Enum ERRORBROKENPIPE for value: ERROR_BROKEN_PIPE
        /// </summary>
        [EnumMember(Value = "ERROR_BROKEN_PIPE")]
        ERRORBROKENPIPE = 2,

        /// <summary>
        /// Enum ERRORIODEVICE for value: ERROR_IO_DEVICE
        /// </summary>
        [EnumMember(Value = "ERROR_IO_DEVICE")]
        ERRORIODEVICE = 3,

        /// <summary>
        /// Enum SCARDFINTERNALERROR for value: SCARD_F_INTERNAL_ERROR
        /// </summary>
        [EnumMember(Value = "SCARD_F_INTERNAL_ERROR")]
        SCARDFINTERNALERROR = 4,

        /// <summary>
        /// Enum SCARDECANCELLED for value: SCARD_E_CANCELLED
        /// </summary>
        [EnumMember(Value = "SCARD_E_CANCELLED")]
        SCARDECANCELLED = 5,

        /// <summary>
        /// Enum SCARDEINVALIDHANDLE for value: SCARD_E_INVALID_HANDLE
        /// </summary>
        [EnumMember(Value = "SCARD_E_INVALID_HANDLE")]
        SCARDEINVALIDHANDLE = 6,

        /// <summary>
        /// Enum SCARDEINVALIDPARAMETER for value: SCARD_E_INVALID_PARAMETER
        /// </summary>
        [EnumMember(Value = "SCARD_E_INVALID_PARAMETER")]
        SCARDEINVALIDPARAMETER = 7,

        /// <summary>
        /// Enum SCARDEINVALIDTARGET for value: SCARD_E_INVALID_TARGET
        /// </summary>
        [EnumMember(Value = "SCARD_E_INVALID_TARGET")]
        SCARDEINVALIDTARGET = 8,

        /// <summary>
        /// Enum SCARDENOMEMORY for value: SCARD_E_NO_MEMORY
        /// </summary>
        [EnumMember(Value = "SCARD_E_NO_MEMORY")]
        SCARDENOMEMORY = 9,

        /// <summary>
        /// Enum SCARDFWAITEDTOOLONG for value: SCARD_F_WAITED_TOO_LONG
        /// </summary>
        [EnumMember(Value = "SCARD_F_WAITED_TOO_LONG")]
        SCARDFWAITEDTOOLONG = 10,

        /// <summary>
        /// Enum SCARDEINSUFFICIENTBUFFER for value: SCARD_E_INSUFFICIENT_BUFFER
        /// </summary>
        [EnumMember(Value = "SCARD_E_INSUFFICIENT_BUFFER")]
        SCARDEINSUFFICIENTBUFFER = 11,

        /// <summary>
        /// Enum SCARDEUNKNOWNREADER for value: SCARD_E_UNKNOWN_READER
        /// </summary>
        [EnumMember(Value = "SCARD_E_UNKNOWN_READER")]
        SCARDEUNKNOWNREADER = 12,

        /// <summary>
        /// Enum SCARDETIMEOUT for value: SCARD_E_TIMEOUT
        /// </summary>
        [EnumMember(Value = "SCARD_E_TIMEOUT")]
        SCARDETIMEOUT = 13,

        /// <summary>
        /// Enum SCARDESHARINGVIOLATION for value: SCARD_E_SHARING_VIOLATION
        /// </summary>
        [EnumMember(Value = "SCARD_E_SHARING_VIOLATION")]
        SCARDESHARINGVIOLATION = 14,

        /// <summary>
        /// Enum SCARDENOSMARTCARD for value: SCARD_E_NO_SMARTCARD
        /// </summary>
        [EnumMember(Value = "SCARD_E_NO_SMARTCARD")]
        SCARDENOSMARTCARD = 15,

        /// <summary>
        /// Enum SCARDEUNKNOWNCARD for value: SCARD_E_UNKNOWN_CARD
        /// </summary>
        [EnumMember(Value = "SCARD_E_UNKNOWN_CARD")]
        SCARDEUNKNOWNCARD = 16,

        /// <summary>
        /// Enum SCARDECANTDISPOSE for value: SCARD_E_CANT_DISPOSE
        /// </summary>
        [EnumMember(Value = "SCARD_E_CANT_DISPOSE")]
        SCARDECANTDISPOSE = 17,

        /// <summary>
        /// Enum SCARDEPROTOMISMATCH for value: SCARD_E_PROTO_MISMATCH
        /// </summary>
        [EnumMember(Value = "SCARD_E_PROTO_MISMATCH")]
        SCARDEPROTOMISMATCH = 18,

        /// <summary>
        /// Enum SCARDENOTREADY for value: SCARD_E_NOT_READY
        /// </summary>
        [EnumMember(Value = "SCARD_E_NOT_READY")]
        SCARDENOTREADY = 19,

        /// <summary>
        /// Enum SCARDEINVALIDVALUE for value: SCARD_E_INVALID_VALUE
        /// </summary>
        [EnumMember(Value = "SCARD_E_INVALID_VALUE")]
        SCARDEINVALIDVALUE = 20,

        /// <summary>
        /// Enum SCARDESYSTEMCANCELLED for value: SCARD_E_SYSTEM_CANCELLED
        /// </summary>
        [EnumMember(Value = "SCARD_E_SYSTEM_CANCELLED")]
        SCARDESYSTEMCANCELLED = 21,

        /// <summary>
        /// Enum SCARDFCOMMERROR for value: SCARD_F_COMM_ERROR
        /// </summary>
        [EnumMember(Value = "SCARD_F_COMM_ERROR")]
        SCARDFCOMMERROR = 22,

        /// <summary>
        /// Enum SCARDFUNKNOWNERROR for value: SCARD_F_UNKNOWN_ERROR
        /// </summary>
        [EnumMember(Value = "SCARD_F_UNKNOWN_ERROR")]
        SCARDFUNKNOWNERROR = 23,

        /// <summary>
        /// Enum SCARDEINVALIDATR for value: SCARD_E_INVALID_ATR
        /// </summary>
        [EnumMember(Value = "SCARD_E_INVALID_ATR")]
        SCARDEINVALIDATR = 24,

        /// <summary>
        /// Enum SCARDENOTTRANSACTED for value: SCARD_E_NOT_TRANSACTED
        /// </summary>
        [EnumMember(Value = "SCARD_E_NOT_TRANSACTED")]
        SCARDENOTTRANSACTED = 25,

        /// <summary>
        /// Enum SCARDEREADERUNAVAILABLE for value: SCARD_E_READER_UNAVAILABLE
        /// </summary>
        [EnumMember(Value = "SCARD_E_READER_UNAVAILABLE")]
        SCARDEREADERUNAVAILABLE = 26,

        /// <summary>
        /// Enum SCARDPSHUTDOWN for value: SCARD_P_SHUTDOWN
        /// </summary>
        [EnumMember(Value = "SCARD_P_SHUTDOWN")]
        SCARDPSHUTDOWN = 27,

        /// <summary>
        /// Enum SCARDEPCITOOSMALL for value: SCARD_E_PCI_TOO_SMALL
        /// </summary>
        [EnumMember(Value = "SCARD_E_PCI_TOO_SMALL")]
        SCARDEPCITOOSMALL = 28,

        /// <summary>
        /// Enum SCARDEREADERUNSUPPORTED for value: SCARD_E_READER_UNSUPPORTED
        /// </summary>
        [EnumMember(Value = "SCARD_E_READER_UNSUPPORTED")]
        SCARDEREADERUNSUPPORTED = 29,

        /// <summary>
        /// Enum SCARDEDUPLICATEREADER for value: SCARD_E_DUPLICATE_READER
        /// </summary>
        [EnumMember(Value = "SCARD_E_DUPLICATE_READER")]
        SCARDEDUPLICATEREADER = 30,

        /// <summary>
        /// Enum SCARDECARDUNSUPPORTED for value: SCARD_E_CARD_UNSUPPORTED
        /// </summary>
        [EnumMember(Value = "SCARD_E_CARD_UNSUPPORTED")]
        SCARDECARDUNSUPPORTED = 31,

        /// <summary>
        /// Enum SCARDENOSERVICE for value: SCARD_E_NO_SERVICE
        /// </summary>
        [EnumMember(Value = "SCARD_E_NO_SERVICE")]
        SCARDENOSERVICE = 32,

        /// <summary>
        /// Enum SCARDESERVICESTOPPED for value: SCARD_E_SERVICE_STOPPED
        /// </summary>
        [EnumMember(Value = "SCARD_E_SERVICE_STOPPED")]
        SCARDESERVICESTOPPED = 33,

        /// <summary>
        /// Enum SCARDEUNEXPECTED for value: SCARD_E_UNEXPECTED
        /// </summary>
        [EnumMember(Value = "SCARD_E_UNEXPECTED")]
        SCARDEUNEXPECTED = 34,

        /// <summary>
        /// Enum SCARDEICCINSTALLATION for value: SCARD_E_ICC_INSTALLATION
        /// </summary>
        [EnumMember(Value = "SCARD_E_ICC_INSTALLATION")]
        SCARDEICCINSTALLATION = 35,

        /// <summary>
        /// Enum SCARDEICCCREATEORDER for value: SCARD_E_ICC_CREATEORDER
        /// </summary>
        [EnumMember(Value = "SCARD_E_ICC_CREATEORDER")]
        SCARDEICCCREATEORDER = 36,

        /// <summary>
        /// Enum SCARDEUNSUPPORTEDFEATURE for value: SCARD_E_UNSUPPORTED_FEATURE
        /// </summary>
        [EnumMember(Value = "SCARD_E_UNSUPPORTED_FEATURE")]
        SCARDEUNSUPPORTEDFEATURE = 37,

        /// <summary>
        /// Enum SCARDEDIRNOTFOUND for value: SCARD_E_DIR_NOT_FOUND
        /// </summary>
        [EnumMember(Value = "SCARD_E_DIR_NOT_FOUND")]
        SCARDEDIRNOTFOUND = 38,

        /// <summary>
        /// Enum SCARDEFILENOTFOUND for value: SCARD_E_FILE_NOT_FOUND
        /// </summary>
        [EnumMember(Value = "SCARD_E_FILE_NOT_FOUND")]
        SCARDEFILENOTFOUND = 39,

        /// <summary>
        /// Enum SCARDENODIR for value: SCARD_E_NO_DIR
        /// </summary>
        [EnumMember(Value = "SCARD_E_NO_DIR")]
        SCARDENODIR = 40,

        /// <summary>
        /// Enum SCARDENOFILE for value: SCARD_E_NO_FILE
        /// </summary>
        [EnumMember(Value = "SCARD_E_NO_FILE")]
        SCARDENOFILE = 41,

        /// <summary>
        /// Enum SCARDENOACCESS for value: SCARD_E_NO_ACCESS
        /// </summary>
        [EnumMember(Value = "SCARD_E_NO_ACCESS")]
        SCARDENOACCESS = 42,

        /// <summary>
        /// Enum SCARDEWRITETOOMANY for value: SCARD_E_WRITE_TOO_MANY
        /// </summary>
        [EnumMember(Value = "SCARD_E_WRITE_TOO_MANY")]
        SCARDEWRITETOOMANY = 43,

        /// <summary>
        /// Enum SCARDEBADSEEK for value: SCARD_E_BAD_SEEK
        /// </summary>
        [EnumMember(Value = "SCARD_E_BAD_SEEK")]
        SCARDEBADSEEK = 44,

        /// <summary>
        /// Enum SCARDEINVALIDCHV for value: SCARD_E_INVALID_CHV
        /// </summary>
        [EnumMember(Value = "SCARD_E_INVALID_CHV")]
        SCARDEINVALIDCHV = 45,

        /// <summary>
        /// Enum SCARDEUNKNOWNRESMNG for value: SCARD_E_UNKNOWN_RES_MNG
        /// </summary>
        [EnumMember(Value = "SCARD_E_UNKNOWN_RES_MNG")]
        SCARDEUNKNOWNRESMNG = 46,

        /// <summary>
        /// Enum SCARDENOSUCHCERTIFICATE for value: SCARD_E_NO_SUCH_CERTIFICATE
        /// </summary>
        [EnumMember(Value = "SCARD_E_NO_SUCH_CERTIFICATE")]
        SCARDENOSUCHCERTIFICATE = 47,

        /// <summary>
        /// Enum SCARDECERTIFICATEUNAVAILABLE for value: SCARD_E_CERTIFICATE_UNAVAILABLE
        /// </summary>
        [EnumMember(Value = "SCARD_E_CERTIFICATE_UNAVAILABLE")]
        SCARDECERTIFICATEUNAVAILABLE = 48,

        /// <summary>
        /// Enum SCARDENOREADERSAVAILABLE for value: SCARD_E_NO_READERS_AVAILABLE
        /// </summary>
        [EnumMember(Value = "SCARD_E_NO_READERS_AVAILABLE")]
        SCARDENOREADERSAVAILABLE = 49,

        /// <summary>
        /// Enum SCARDECOMMDATALOST for value: SCARD_E_COMM_DATA_LOST
        /// </summary>
        [EnumMember(Value = "SCARD_E_COMM_DATA_LOST")]
        SCARDECOMMDATALOST = 50,

        /// <summary>
        /// Enum SCARDENOKEYCONTAINER for value: SCARD_E_NO_KEY_CONTAINER
        /// </summary>
        [EnumMember(Value = "SCARD_E_NO_KEY_CONTAINER")]
        SCARDENOKEYCONTAINER = 51,

        /// <summary>
        /// Enum SCARDESERVERTOOBUSY for value: SCARD_E_SERVER_TOO_BUSY
        /// </summary>
        [EnumMember(Value = "SCARD_E_SERVER_TOO_BUSY")]
        SCARDESERVERTOOBUSY = 52,

        /// <summary>
        /// Enum SCARDEPINCACHEEXPIRED for value: SCARD_E_PIN_CACHE_EXPIRED
        /// </summary>
        [EnumMember(Value = "SCARD_E_PIN_CACHE_EXPIRED")]
        SCARDEPINCACHEEXPIRED = 53,

        /// <summary>
        /// Enum SCARDENOPINCACHE for value: SCARD_E_NO_PIN_CACHE
        /// </summary>
        [EnumMember(Value = "SCARD_E_NO_PIN_CACHE")]
        SCARDENOPINCACHE = 54,

        /// <summary>
        /// Enum SCARDEREADONLYCARD for value: SCARD_E_READ_ONLY_CARD
        /// </summary>
        [EnumMember(Value = "SCARD_E_READ_ONLY_CARD")]
        SCARDEREADONLYCARD = 55,

        /// <summary>
        /// Enum SCARDWUNSUPPORTEDCARD for value: SCARD_W_UNSUPPORTED_CARD
        /// </summary>
        [EnumMember(Value = "SCARD_W_UNSUPPORTED_CARD")]
        SCARDWUNSUPPORTEDCARD = 56,

        /// <summary>
        /// Enum SCARDWUNRESPONSIVECARD for value: SCARD_W_UNRESPONSIVE_CARD
        /// </summary>
        [EnumMember(Value = "SCARD_W_UNRESPONSIVE_CARD")]
        SCARDWUNRESPONSIVECARD = 57,

        /// <summary>
        /// Enum SCARDWUNPOWEREDCARD for value: SCARD_W_UNPOWERED_CARD
        /// </summary>
        [EnumMember(Value = "SCARD_W_UNPOWERED_CARD")]
        SCARDWUNPOWEREDCARD = 58,

        /// <summary>
        /// Enum SCARDWRESETCARD for value: SCARD_W_RESET_CARD
        /// </summary>
        [EnumMember(Value = "SCARD_W_RESET_CARD")]
        SCARDWRESETCARD = 59,

        /// <summary>
        /// Enum SCARDWREMOVEDCARD for value: SCARD_W_REMOVED_CARD
        /// </summary>
        [EnumMember(Value = "SCARD_W_REMOVED_CARD")]
        SCARDWREMOVEDCARD = 60,

        /// <summary>
        /// Enum SCARDWSECURITYVIOLATION for value: SCARD_W_SECURITY_VIOLATION
        /// </summary>
        [EnumMember(Value = "SCARD_W_SECURITY_VIOLATION")]
        SCARDWSECURITYVIOLATION = 61,

        /// <summary>
        /// Enum SCARDWWRONGCHV for value: SCARD_W_WRONG_CHV
        /// </summary>
        [EnumMember(Value = "SCARD_W_WRONG_CHV")]
        SCARDWWRONGCHV = 62,

        /// <summary>
        /// Enum SCARDWCHVBLOCKED for value: SCARD_W_CHV_BLOCKED
        /// </summary>
        [EnumMember(Value = "SCARD_W_CHV_BLOCKED")]
        SCARDWCHVBLOCKED = 63,

        /// <summary>
        /// Enum SCARDWEOF for value: SCARD_W_EOF
        /// </summary>
        [EnumMember(Value = "SCARD_W_EOF")]
        SCARDWEOF = 64,

        /// <summary>
        /// Enum SCARDWCANCELLEDBYUSER for value: SCARD_W_CANCELLED_BY_USER
        /// </summary>
        [EnumMember(Value = "SCARD_W_CANCELLED_BY_USER")]
        SCARDWCANCELLEDBYUSER = 65,

        /// <summary>
        /// Enum SCARDWCARDNOTAUTHENTICATED for value: SCARD_W_CARD_NOT_AUTHENTICATED
        /// </summary>
        [EnumMember(Value = "SCARD_W_CARD_NOT_AUTHENTICATED")]
        SCARDWCARDNOTAUTHENTICATED = 66,

        /// <summary>
        /// Enum SCARDWCACHEITEMNOTFOUND for value: SCARD_W_CACHE_ITEM_NOT_FOUND
        /// </summary>
        [EnumMember(Value = "SCARD_W_CACHE_ITEM_NOT_FOUND")]
        SCARDWCACHEITEMNOTFOUND = 67,

        /// <summary>
        /// Enum SCARDWCACHEITEMSTALE for value: SCARD_W_CACHE_ITEM_STALE
        /// </summary>
        [EnumMember(Value = "SCARD_W_CACHE_ITEM_STALE")]
        SCARDWCACHEITEMSTALE = 68,

        /// <summary>
        /// Enum SCARDWCACHEITEMTOOBIG for value: SCARD_W_CACHE_ITEM_TOO_BIG
        /// </summary>
        [EnumMember(Value = "SCARD_W_CACHE_ITEM_TOO_BIG")]
        SCARDWCACHEITEMTOOBIG = 69
    }

}
