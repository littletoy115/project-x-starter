'use strict';

(() => {
  var _0x2cc136 = /^[A-Za-z][A-Za-z0-9_]*(\.[A-Za-z][A-Za-z0-9_]*)+$/;
  var _0x68ab1c = /^[0-9a-f]{64}$/;
  var _0x5aac74 = new Set(["capy_license_protocol_version", "capy_license_context_create", "capy_license_context_handshake", "capy_license_context_configure", "capy_license_context_server", "capy_license_request_start", "capy_license_probe_start", "capy_license_request_poll", "capy_license_request_cancel", "capy_license_context_destroy"]);
  function _0x1ba714(_0x5b2c54) {
    return {
      ok: false,
      error: _0x5b2c54
    };
  }
  function _0x4e8b23(_0x19b077) {
    if (_0x19b077 === null || typeof _0x19b077 != "object" || Array.isArray(_0x19b077)) {
      return _0x1ba714("invalid descriptor");
    }
    let _0x34ac88 = _0x19b077;
    if (typeof _0x34ac88.package != "string" || !_0x2cc136.test(_0x34ac88.package)) {
      return _0x1ba714("invalid package");
    }
    if (typeof _0x34ac88.sha256 != "string" || !_0x68ab1c.test(_0x34ac88.sha256)) {
      return _0x1ba714("invalid sha256");
    }
    if (typeof _0x34ac88.path != "string") {
      return _0x1ba714("invalid library path");
    }
    let _0x3a4726 = "/" + _0x34ac88.package + "/code_cache/capybara-license/" + _0x34ac88.sha256 + "/libshare.so";
    if (_0x34ac88.path !== "/data/user/0" + _0x3a4726 && _0x34ac88.path !== "/data/data" + _0x3a4726) {
      return _0x1ba714("invalid library path");
    } else {
      return {
        path: _0x34ac88.path,
        sha256: _0x34ac88.sha256,
        package: _0x34ac88.package
      };
    }
  }
  function _0x2ddb9a(_0x32897c) {
    return _0x32897c.package + "\n" + _0x32897c.sha256 + "\n" + _0x32897c.path;
  }
  function _0x337815(_0xded7) {
    let _0x4b5c19 = _0xded7;
    let _0x378139 = null;
    let _0x399516 = null;
    let _0x25aada = null;
    let _0xe165f = false;
    function _0x76b40e(_0x8375bb, _0x380511) {
      _0x399516 = _0x8375bb;
      _0x25aada = _0x380511;
      return _0x380511;
    }
    return {
      initialize(_0xf08525) {
        if (_0xe165f || _0x4b5c19 === null) {
          return _0x1ba714("native loader released");
        }
        let _0x37b836 = _0x4e8b23(_0xf08525);
        if (!("path" in _0x37b836)) {
          return _0x37b836;
        }
        let _0x139164 = _0x2ddb9a(_0x37b836);
        if (_0x399516 !== null) {
          if (_0x399516 === _0x139164 && _0x25aada !== null && _0x378139 !== null) {
            return _0x25aada;
          } else {
            return _0x1ba714("native library already initialized");
          }
        }
        if (_0x4b5c19.architecture !== "arm64") {
          return _0x1ba714("unsupported process architecture");
        }
        let _0x3b96a9;
        try {
          _0x3b96a9 = _0x4b5c19.open(_0x37b836.path, 1);
          _0x378139 = {
            handle: _0x3b96a9,
            versionSymbol: null,
            abiSymbol: null
          };
          if (_0x4b5c19.isNull(_0x3b96a9)) {
            _0x378139 = null;
            return _0x1ba714("native library load failed");
          }
        } catch {
          let _0x262ee3 = _0x1ba714("native loader failure");
          if (_0x378139 === null) {
            return _0x262ee3;
          } else {
            return _0x76b40e(_0x139164, _0x262ee3);
          }
        }
        try {
          let _0x860edd = _0x4b5c19.symbol(_0x3b96a9, "capy_license_api_version");
          let _0x255381 = _0x4b5c19.symbol(_0x3b96a9, "capy_license_build_abi");
          _0x378139.versionSymbol = _0x860edd;
          _0x378139.abiSymbol = _0x255381;
          if (_0x4b5c19.isNull(_0x860edd) || _0x4b5c19.isNull(_0x255381)) {
            return _0x76b40e(_0x139164, _0x1ba714("required native export missing"));
          } else if (_0x4b5c19.invokeVersion(_0x860edd) !== 1) {
            return _0x76b40e(_0x139164, _0x1ba714("unsupported native API version"));
          } else if (_0x4b5c19.invokeAbi(_0x255381) !== "arm64-v8a") {
            return _0x76b40e(_0x139164, _0x1ba714("unsupported native ABI"));
          } else {
            return _0x76b40e(_0x139164, {
              ok: true,
              apiVersion: 1,
              buildAbi: "arm64-v8a",
              sha256: _0x37b836.sha256
            });
          }
        } catch {
          return _0x76b40e(_0x139164, _0x1ba714("native loader failure"));
        }
      },
      resolve(_0x10cc7d) {
        if (_0xe165f || _0x4b5c19 === null || _0x378139 === null || _0x25aada === null || !_0x25aada.ok || !_0x5aac74.has(_0x10cc7d)) {
          return null;
        }
        try {
          let _0x130fe1 = _0x4b5c19.symbol(_0x378139.handle, _0x10cc7d);
          if (_0x4b5c19.isNull(_0x130fe1)) {
            return null;
          } else {
            return _0x130fe1;
          }
        } catch {
          return null;
        }
      },
      release() {
        _0x378139 = null;
        _0x399516 = null;
        _0x25aada = null;
        _0x4b5c19 = null;
        _0xe165f = true;
      }
    };
  }
  var _0x203343 = {
    requestDeadlineMs: 10000,
    retryDelayMs: 5000,
    attemptsPerRound: 6,
    roundDelayMs: 600000,
    failedRoundsBeforeTerminate: 3
  };
  function _0x282f5d(_0x2572ce, _0x3d4fc4) {
    if (_0x2572ce.status !== 200) {
      return {
        accepted: false,
        reason: "http_" + _0x2572ce.status
      };
    }
    let _0x2f7586;
    try {
      _0x2f7586 = JSON.parse(_0x2572ce.body);
    } catch {
      return {
        accepted: false,
        reason: "invalid_json"
      };
    }
    if (_0x2f7586 === null || typeof _0x2f7586 != "object" || Array.isArray(_0x2f7586)) {
      return {
        accepted: false,
        reason: "invalid_response"
      };
    }
    let _0x2c0a51 = _0x2f7586;
    if (_0x2c0a51.serverId !== _0x3d4fc4) {
      return {
        accepted: false,
        reason: "server_mismatch"
      };
    }
    if (Object.prototype.hasOwnProperty.call(_0x2c0a51, "concurrent")) {
      if (_0x2c0a51.concurrent === true) {
        return {
          accepted: false,
          reason: "concurrent"
        };
      }
      if (_0x2c0a51.concurrent !== false) {
        return {
          accepted: false,
          reason: "invalid_response"
        };
      }
    }
    if (_0x2c0a51.success !== true) {
      return {
        accepted: false,
        reason: "rejected"
      };
    } else {
      return {
        accepted: true,
        reason: "accepted"
      };
    }
  }
  var _0x53f0c5 = class {
    expectedServer;
    generation;
    access;
    authorized = false;
    failedRounds = 0;
    attempt = 0;
    started = false;
    disposed = false;
    terminating = false;
    timer = null;
    active = null;
    nextRequestId = 1;
    constructor(_0x19e4ba, _0x44a12c, _0x2ceec3) {
      this.expectedServer = _0x19e4ba;
      this.generation = _0x44a12c;
      this.access = _0x2ceec3;
    }
    start() {
      if (!this.started && !this.disposed && !this.terminating) {
        this.started = true;
        this.publish("pending", "awaiting_first_acceptance");
        this.beginAttempt();
      }
    }
    dispose() {
      if (this.disposed) {
        return;
      }
      this.disposed = true;
      this.authorized = false;
      this.clearTimer();
      let _0x597d5f = this.active;
      this.active = null;
      if (_0x597d5f !== null) {
        this.cancel(_0x597d5f);
      }
      this.publish("disposed", "disposed");
    }
    beginAttempt() {
      if (this.disposed || this.terminating || this.active !== null) {
        return;
      }
      this.attempt++;
      let _0x59c709 = this.nextRequestId++;
      let _0xf18699 = this.access.now();
      let _0x5cdd22;
      try {
        _0x5cdd22 = this.access.request();
      } catch {
        this.failAttempt("transport");
        return;
      }
      let _0x1af79d = {
        id: _0x59c709,
        startedAt: _0xf18699,
        cancel: () => _0x5cdd22.cancel()
      };
      if (this.disposed || this.terminating) {
        this.cancel(_0x1af79d);
        return;
      }
      this.active = _0x1af79d;
      let _0x3518c3 = Math.max(0, this.access.now() - _0xf18699);
      this.timer = this.access.setTimeout(() => this.deadline(_0x59c709), Math.max(0, _0x203343.requestDeadlineMs - _0x3518c3));
      _0x5cdd22.promise.then(_0x3604d9 => this.complete(_0x59c709, _0x3604d9), () => this.completeFailure(_0x59c709, "transport"));
    }
    complete(_0x393c4e, _0x4d930c) {
      let _0x3cb8ec = this.takeActive(_0x393c4e);
      if (_0x3cb8ec === null) {
        return;
      }
      if (this.expired(_0x3cb8ec)) {
        this.cancel(_0x3cb8ec);
        this.failAttempt("deadline");
        return;
      }
      let _0x358c54 = _0x282f5d(_0x4d930c, this.expectedServer);
      if (_0x358c54.accepted) {
        this.accept();
      } else {
        this.failAttempt(_0x358c54.reason);
      }
    }
    completeFailure(_0x35f0fa, _0x4bbee1) {
      let _0x5c31d5 = this.takeActive(_0x35f0fa);
      if (_0x5c31d5 !== null) {
        if (this.expired(_0x5c31d5)) {
          this.cancel(_0x5c31d5);
          this.failAttempt("deadline");
        } else {
          this.failAttempt(_0x4bbee1);
        }
      }
    }
    deadline(_0xc44425) {
      let _0x314c5f = this.active;
      if (!this.disposed && !this.terminating && _0x314c5f !== null && _0x314c5f.id === _0xc44425) {
        this.active = null;
        this.timer = null;
        this.cancel(_0x314c5f);
        this.failAttempt("deadline");
      }
    }
    takeActive(_0x4aa580) {
      if (this.disposed || this.terminating || this.active === null || this.active.id !== _0x4aa580) {
        return null;
      }
      let _0x4529e3 = this.active;
      this.active = null;
      this.clearTimer();
      return _0x4529e3;
    }
    expired(_0x26a59d) {
      return this.access.now() - _0x26a59d.startedAt >= _0x203343.requestDeadlineMs;
    }
    accept() {
      if (!this.disposed && !this.terminating) {
        this.authorized = true;
        this.failedRounds = 0;
        this.attempt = 0;
        this.publish("accepted", "accepted");
        this.schedule(_0x203343.roundDelayMs);
      }
    }
    failAttempt(_0x3fcf73) {
      if (!this.disposed && !this.terminating) {
        if (this.attempt < _0x203343.attemptsPerRound) {
          this.publish("retrying", _0x3fcf73);
          this.schedule(_0x203343.retryDelayMs);
          return;
        }
        this.failedRounds++;
        this.attempt = 0;
        if (this.failedRounds >= _0x203343.failedRoundsBeforeTerminate) {
          this.terminating = true;
          this.authorized = false;
          this.publish("terminating", _0x3fcf73);
          if (!this.disposed) {
            this.access.terminate();
          }
          return;
        }
        this.publish("waiting", _0x3fcf73);
        this.schedule(_0x203343.roundDelayMs);
      }
    }
    schedule(_0x43b9b0) {
      if (!this.disposed && !this.terminating) {
        this.clearTimer();
        this.timer = this.access.setTimeout(() => {
          this.timer = null;
          this.beginAttempt();
        }, _0x43b9b0);
      }
    }
    clearTimer() {
      if (this.timer !== null) {
        this.access.clearTimeout(this.timer);
        this.timer = null;
      }
    }
    cancel(_0x2761ac) {
      try {
        _0x2761ac.cancel();
      } catch {}
    }
    publish(_0x21e693, _0x17bd44) {
      this.access.status({
        generation: this.generation,
        state: _0x21e693,
        authorized: this.authorized,
        reason: _0x17bd44,
        attempt: this.attempt,
        failedRounds: this.failedRounds
      });
    }
  };
  var _0xd6db95 = 100;
  var _0x43cef4 = 2147483647;
  var _0xdabe31 = {
    [-1]: "invalid_argument",
    [-2]: "invalid_context",
    [-3]: "buffer_too_small",
    [-4]: "random_failure",
    [-5]: "crypto_failure",
    [-6]: "protocol_failure",
    [-7]: "authentication_failed",
    [-8]: "policy_mismatch",
    [-9]: "not_configured",
    [-10]: "request_mismatch",
    [-11]: "transport_failure",
    [-12]: "response_too_large",
    [-13]: "cancelled",
    [-14]: "deadline_exceeded",
    [-15]: "resource_limit",
    [-16]: "internal_error"
  };
  function _0x1bad26(_0x536bc4) {
    if (typeof _0x536bc4 == "number" && Number.isInteger(_0x536bc4) && _0x536bc4 >= 1 && _0x536bc4 <= _0x43cef4) {
      return _0x536bc4;
    } else {
      return null;
    }
  }
  function _0xcd644d(_0x59f1a5) {
    if (typeof _0x59f1a5 == "number" && _0xdabe31[_0x59f1a5] !== undefined) {
      return _0xdabe31[_0x59f1a5];
    } else {
      return "native_failure";
    }
  }
  function _0x53ff5a(_0x503ec1, _0x571164) {
    if (typeof _0x503ec1 == "string" && _0x503ec1.length === _0x571164 * 2 && /^[0-9a-f]+$/.test(_0x503ec1)) {
      return _0x503ec1;
    } else {
      return null;
    }
  }
  function _0x2f0112(_0x38d310) {
    if (typeof _0x38d310 == "string" && _0x38d310.length >= 2 && _0x38d310.length <= 8192 && _0x38d310.length % 2 === 0 && /^[0-9a-f]+$/.test(_0x38d310)) {
      return _0x38d310;
    } else {
      return null;
    }
  }
  function _0x4db4b1(_0x531a4b) {
    let _0x5c1fa6 = new Uint8Array(_0x531a4b.length / 2);
    for (let _0x39a54b = 0; _0x39a54b < _0x5c1fa6.length; _0x39a54b++) {
      _0x5c1fa6[_0x39a54b] = parseInt(_0x531a4b.slice(_0x39a54b * 2, _0x39a54b * 2 + 2), 16);
    }
    return _0x5c1fa6;
  }
  function _0x322ca2(_0x407647) {
    let _0x2e8b65 = "";
    for (let _0x2ce06b of _0x407647) {
      _0x2e8b65 += _0x2ce06b.toString(16).padStart(2, "0");
    }
    return _0x2e8b65;
  }
  var _0x4b9c86 = class {
    native;
    access;
    current = null;
    generation = 0;
    constructor(_0x4e78b4, _0x1cb8f7) {
      this.native = _0x4e78b4;
      this.access = _0x1cb8f7;
    }
    open(_0x245a90, _0xed129c) {
      let _0x1c3e76 = _0x1bad26(_0x245a90?.req);
      this.disposeCurrent();
      if (_0x1c3e76 === null) {
        this.openFailure(0, "invalid_request");
        return;
      }
      let _0x464d51 = null;
      try {
        if (this.native.protocolVersion() !== 1) {
          this.openFailure(_0x1c3e76, "unsupported_protocol");
          return;
        }
        _0x464d51 = this.native.create();
        if (_0x464d51 == null) {
          this.openFailure(_0x1c3e76, "context_create_failed");
          return;
        }
        let _0x5b7f33 = this.native.handshake(_0x464d51);
        if (!(_0x5b7f33 instanceof Uint8Array) || _0x5b7f33.length !== 113 || _0x5b7f33[48] !== 4) {
          this.safeDestroy(_0x464d51);
          this.openFailure(_0x1c3e76, "invalid_handshake");
          return;
        }
        let _0x5d2a28 = ++this.generation;
        let _0x1e7856 = _0x322ca2(_0x5b7f33.slice(0, 16));
        this.current = {
          context: _0x464d51,
          generation: _0x5d2a28,
          sessionId: _0x1e7856,
          configured: false,
          controller: null,
          nextRequest: 1
        };
        this.access.opened(_0x1e7856, _0x5d2a28);
        this.access.send({
          t: "license_hello",
          req: _0x1c3e76,
          ok: true,
          protocol: 1,
          pid: _0xed129c,
          sessionId: _0x1e7856,
          challenge: _0x322ca2(_0x5b7f33.slice(16, 48)),
          publicKey: _0x322ca2(_0x5b7f33.slice(48, 113))
        });
      } catch (_0x76927) {
        if (_0x464d51 !== null) {
          this.safeDestroy(_0x464d51);
        }
        this.current = null;
        this.openFailure(_0x1c3e76, _0xcd644d(_0x76927));
      }
    }
    bootstrap(_0x539ebc) {
      let _0x20fbf2 = _0x1bad26(_0x539ebc?.req);
      let _0x1562f7 = this.current;
      let _0x51b7e3 = _0x53ff5a(_0x539ebc?.sessionId, 16);
      let _0x1162cd = _0x53ff5a(_0x539ebc?.clientPublicKey, 65);
      let _0x477afb = _0x53ff5a(_0x539ebc?.nonce, 12);
      let _0x208227 = _0x53ff5a(_0x539ebc?.tag, 16);
      let _0x486c38 = _0x2f0112(_0x539ebc?.ciphertext);
      if (_0x20fbf2 === null || _0x1562f7 === null || _0x1562f7.configured || _0x51b7e3 === null || _0x51b7e3 !== _0x1562f7.sessionId || _0x1162cd === null || !_0x1162cd.startsWith("04") || _0x477afb === null || _0x208227 === null || _0x486c38 === null) {
        this.access.send({
          t: "license_bootstrap",
          req: _0x20fbf2 ?? 0,
          sessionId: _0x51b7e3 ?? "",
          ok: false,
          error: "invalid_bootstrap"
        });
        return;
      }
      try {
        let _0x42a72f = _0x4db4b1(_0x1162cd + _0x477afb + _0x208227 + _0x486c38);
        let _0x3888bd;
        try {
          _0x3888bd = this.native.configure(_0x1562f7.context, _0x42a72f);
        } finally {
          _0x42a72f.fill(0);
        }
        if (_0x3888bd !== 1) {
          this.access.send({
            t: "license_bootstrap",
            req: _0x20fbf2,
            sessionId: _0x51b7e3,
            ok: false,
            error: _0xcd644d(_0x3888bd)
          });
          return;
        }
        let _0x125623 = this.native.server(_0x1562f7.context);
        if (typeof _0x125623 != "string" || _0x125623.length < 1 || _0x125623.length > 1024) {
          this.access.send({
            t: "license_bootstrap",
            req: _0x20fbf2,
            sessionId: _0x51b7e3,
            ok: false,
            error: "invalid_server"
          });
          this.disposeCurrent();
          return;
        }
        _0x1562f7.configured = true;
        this.access.send({
          t: "license_bootstrap",
          req: _0x20fbf2,
          sessionId: _0x51b7e3,
          ok: true
        });
        if (this.current !== _0x1562f7) {
          return;
        }
        this.startController(_0x1562f7, _0x125623);
      } catch (_0x35d3ed) {
        this.access.send({
          t: "license_bootstrap",
          req: _0x20fbf2,
          sessionId: _0x51b7e3,
          ok: false,
          error: _0xcd644d(_0x35d3ed)
        });
      }
    }
    dispose(_0x52c7cd) {
      let _0x1b50a1 = this.current;
      if (_0x1b50a1 !== null) {
        if (_0x52c7cd === undefined || _0x52c7cd === _0x1b50a1.sessionId) {
          this.disposeCurrent();
        }
      }
    }
    startController(_0x2f48b4, _0x3ead38) {
      let _0x81e720 = new _0x53f0c5(_0x3ead38, _0x2f48b4.generation, {
        now: this.access.now,
        setTimeout: this.access.setTimeout,
        clearTimeout: this.access.clearTimeout,
        request: () => this.request(_0x2f48b4),
        status: _0x2b1bec => this.status(_0x2f48b4, _0x2b1bec),
        terminate: () => {
          if (this.current === _0x2f48b4) {
            this.access.terminate();
          }
        }
      });
      _0x2f48b4.controller = _0x81e720;
      _0x81e720.start();
    }
    request(_0x157162) {
      if (this.current !== _0x157162 || !_0x157162.configured) {
        throw new Error("inactive native session");
      }
      let _0x120fd5 = _0x157162.nextRequest++;
      if (_0x157162.nextRequest > _0x43cef4) {
        _0x157162.nextRequest = 1;
      }
      let _0x40ae47 = this.native.requestStart(_0x157162.context, _0x120fd5);
      if (_0x40ae47 !== 1) {
        throw _0x40ae47;
      }
      let _0x433ede = null;
      let _0x22588b = false;
      let _0x1933a2 = () => {};
      return {
        promise: new Promise((_0x36b275, _0x53ec1f) => {
          _0x1933a2 = _0x53ec1f;
          let _0x21f699 = () => {
            _0x433ede = null;
            if (!_0x22588b && this.current === _0x157162) {
              try {
                let _0x4e5ae0 = this.native.requestPoll(_0x157162.context, _0x120fd5);
                if (_0x4e5ae0.pending) {
                  _0x433ede = this.access.setTimeout(_0x21f699, _0xd6db95);
                  return;
                }
                _0x22588b = true;
                _0x36b275({
                  status: _0x4e5ae0.status,
                  body: _0x4e5ae0.body
                });
              } catch (_0x384828) {
                _0x22588b = true;
                _0x53ec1f(_0xcd644d(_0x384828));
              }
            }
          };
          _0x433ede = this.access.setTimeout(_0x21f699, _0xd6db95);
        }),
        cancel: () => {
          if (!_0x22588b) {
            _0x22588b = true;
            if (_0x433ede !== null) {
              this.access.clearTimeout(_0x433ede);
            }
            _0x433ede = null;
            try {
              this.native.requestCancel(_0x157162.context, _0x120fd5);
            } catch {}
            _0x1933a2("cancelled");
          }
        }
      };
    }
    status(_0x15c329, _0x2dc355) {
      if (this.current !== _0x15c329 || _0x2dc355.generation !== _0x15c329.generation) {
        return;
      }
      let _0x1e285a = _0x2dc355.state === "terminating" || _0x2dc355.state === "disposed";
      this.access.authorization(_0x15c329.generation, _0x2dc355.authorized, _0x1e285a);
      this.access.send({
        t: "license_status",
        sessionId: _0x15c329.sessionId,
        authorized: _0x2dc355.authorized,
        state: _0x2dc355.state,
        reason: _0x2dc355.reason,
        attempt: _0x2dc355.attempt,
        round: _0x2dc355.failedRounds
      });
    }
    disposeCurrent() {
      let _0x4551a0 = this.current;
      if (_0x4551a0 !== null) {
        this.current = null;
        _0x4551a0.controller?.dispose();
        this.access.authorization(_0x4551a0.generation, false, true);
        this.access.disposed(_0x4551a0.generation);
        this.safeDestroy(_0x4551a0.context);
      }
    }
    safeDestroy(_0x5e1052) {
      try {
        this.native.destroy(_0x5e1052);
      } catch {}
    }
    openFailure(_0x5d6c9b, _0x88e0e1) {
      this.access.send({
        t: "license_hello",
        req: _0x5d6c9b,
        ok: false,
        error: _0x88e0e1
      });
    }
  };
  var _0x88c7f0 = Math.PI * 2;
  var _0x3954cb = 70;
  var _0x44152d = Math.PI * 58 / 180;
  var _0xc6595e = 24;
  var _0x574b02 = 32;
  var _0x27f9be = 48;
  var _0x32efb8 = 0.34;
  var _0x12337a = 1708;
  var _0x7645e2 = 4920;
  function _0x5b00df(_0x2e7e1f) {
    return typeof _0x2e7e1f == "number" && Number.isFinite(_0x2e7e1f);
  }
  function _0xe8b9c2(_0x1698a1) {
    let _0x3dc4d3 = _0x1698a1 === undefined ? "default" : _0x1698a1;
    if (typeof _0x3dc4d3 == "string" && _0x3dc4d3.length > 0 && _0x3dc4d3.length <= 128) {
      return _0x3dc4d3;
    } else {
      return null;
    }
  }
  function _0x1ff9c9(_0x602d8, _0x1c66dc) {
    let _0x526edc = _0x602d8 === undefined ? _0x1c66dc : _0x602d8;
    if (_0x5b00df(_0x526edc) && _0x526edc > 0 && _0x526edc <= 10000) {
      return _0x526edc;
    } else {
      return null;
    }
  }
  function _0x403b96(_0xe96815) {
    let _0x44a10d = _0xe96815.r === undefined ? 0.2 : _0xe96815.r;
    let _0xd3a34d = _0xe96815.g === undefined ? 1 : _0xe96815.g;
    let _0x292a84 = _0xe96815.b === undefined ? 0.3 : _0xe96815.b;
    let _0xc568fc = _0xe96815.a === undefined ? 0.25 : _0xe96815.a;
    if (!_0x5b00df(_0x44a10d) || _0x44a10d < 0 || _0x44a10d > 1 || !_0x5b00df(_0xd3a34d) || _0xd3a34d < 0 || _0xd3a34d > 1 || !_0x5b00df(_0x292a84) || _0x292a84 < 0 || _0x292a84 > 1 || !_0x5b00df(_0xc568fc) || _0xc568fc < 0 || _0xc568fc > 1) {
      return null;
    } else {
      return [_0x44a10d, _0xd3a34d, _0x292a84, _0xc568fc];
    }
  }
  function _0x5b4212(_0x5af53c) {
    let _0xddc8d8 = _0xe8b9c2(_0x5af53c?.id);
    if (_0xddc8d8 === null) {
      return {
        ok: false,
        error: "Radar id must be 1-128 characters"
      };
    }
    if (_0x5af53c === null || typeof _0x5af53c != "object") {
      return {
        ok: false,
        error: "Radar command must be an object"
      };
    }
    if (_0x5af53c.w !== undefined || _0x5af53c.x2 !== undefined || _0x5af53c.y2 !== undefined || _0x5af53c.z2 !== undefined) {
      return {
        ok: false,
        error: "Radar does not support line zones"
      };
    }
    if (_0x5af53c.on === false) {
      return {
        ok: true,
        command: {
          kind: "hide",
          id: _0xddc8d8
        }
      };
    }
    if (_0x5af53c.on !== true) {
      let _0x3822ea = _0x1ff9c9(_0x5af53c.radius);
      if (_0x3822ea === null) {
        return {
          ok: false,
          error: "Radar resize radius must be finite and positive"
        };
      } else {
        return {
          ok: true,
          command: {
            kind: "resize",
            id: _0xddc8d8,
            radius: _0x3822ea
          }
        };
      }
    }
    let _0xeee236 = _0x1ff9c9(_0x5af53c.radius, 60);
    if (_0xeee236 === null) {
      return {
        ok: false,
        error: "Radar radius must be finite and positive"
      };
    }
    let _0x556896 = _0x403b96(_0x5af53c);
    if (_0x556896 === null) {
      return {
        ok: false,
        error: "Radar colour channels must be finite values from 0 to 1"
      };
    }
    let _0x30dd44 = (_0x5af53c.x === undefined ? 0 : 1) + (_0x5af53c.y === undefined ? 0 : 1) + (_0x5af53c.z === undefined ? 0 : 1);
    if (_0x30dd44 !== 0 && _0x30dd44 !== 3) {
      return {
        ok: false,
        error: "Radar fixed circles require all x, y and z coordinates"
      };
    }
    if (_0x30dd44 === 3 && (!_0x5b00df(_0x5af53c.x) || !_0x5b00df(_0x5af53c.y) || !_0x5b00df(_0x5af53c.z))) {
      return {
        ok: false,
        error: "Radar fixed coordinates must be finite"
      };
    }
    let _0x59442d = _0x30dd44 === 3 ? {
      x: _0x5af53c.x,
      y: _0x5af53c.y,
      z: _0x5af53c.z
    } : null;
    return {
      ok: true,
      command: {
        kind: "show",
        id: _0xddc8d8,
        radius: _0xeee236,
        rgba: _0x556896,
        fixed: _0x59442d
      }
    };
  }
  function _0x51b8f4(_0xd62361, _0x32a26d) {
    if (!_0xd62361.nativeReady || _0xd62361.loading !== false || _0xd62361.loadingAgeMs === null || !_0x5b00df(_0xd62361.loadingAgeMs) || _0xd62361.loadingAgeMs < 0 || _0xd62361.loadingAgeMs > 1000 || _0xd62361.self === null || !_0x5b00df(_0xd62361.self.ageMs) || _0xd62361.self.ageMs < 0 || _0xd62361.self.ageMs > 1000 || !_0x5b00df(_0xd62361.self.x) || !_0x5b00df(_0xd62361.self.y) || !_0x5b00df(_0xd62361.self.z)) {
      return null;
    } else if (_0x32a26d === null) {
      return {
        x: _0xd62361.self.x,
        y: _0xd62361.self.y,
        z: _0xd62361.self.z
      };
    } else if (!_0x5b00df(_0x32a26d.x) || !_0x5b00df(_0x32a26d.y) || !_0x5b00df(_0x32a26d.z)) {
      return null;
    } else {
      return {
        x: _0x32a26d.x,
        y: _0x32a26d.y,
        z: _0x32a26d.z
      };
    }
  }
  function _0x42ed96(_0xe46e6a) {
    let _0x2e22c5 = new Float64Array(_0xe46e6a * 2);
    for (let _0x1815d5 = 0; _0x1815d5 < _0xe46e6a; _0x1815d5++) {
      let _0x3ed808 = _0x88c7f0 * _0x1815d5 / _0xe46e6a;
      _0x2e22c5[_0x1815d5 * 2] = Math.cos(_0x3ed808);
      _0x2e22c5[_0x1815d5 * 2 + 1] = Math.sin(_0x3ed808);
    }
    return _0x2e22c5;
  }
  var _0xf00c2 = _0x42ed96(8);
  var _0x45fabc = _0x42ed96(12);
  var _0x58f97c = _0x42ed96(16);
  var _0x3cee8f = _0x42ed96(_0x574b02);
  var _0x467e95 = _0x42ed96(_0x27f9be);
  function _0x151610(_0x301ca1, _0x1814f9) {
    return Math.max(0, Math.min(1, _0x1814f9 * _0x301ca1[3] / 0.25));
  }
  function _0x30e838(_0x5e2a91, _0x44ffe1, _0x4440f8, _0x2a0a9b, _0x3a5712, _0x5d6670, _0x3f945b) {
    let _0x534917 = _0x5e2a91.vertexCount++;
    let _0x207950 = _0x534917 * 3;
    _0x5e2a91.positions[_0x207950] = _0x44ffe1;
    _0x5e2a91.positions[_0x207950 + 1] = 0;
    _0x5e2a91.positions[_0x207950 + 2] = _0x4440f8;
    let _0x1c6f18 = _0x534917 * 4;
    _0x5e2a91.colours[_0x1c6f18] = _0x2a0a9b;
    _0x5e2a91.colours[_0x1c6f18 + 1] = _0x3a5712;
    _0x5e2a91.colours[_0x1c6f18 + 2] = _0x5d6670;
    _0x5e2a91.colours[_0x1c6f18 + 3] = _0x3f945b;
    return _0x534917;
  }
  function _0x470fa2(_0x32c4eb, _0x5cc587, _0x421f29, _0xb7e02e, _0x37a577, _0x15a2d3, _0x4ff0dd, _0x2748fe, _0x5ef7cd, _0x258713, _0x1a2712, _0x2a0a33) {
    let _0x3f186e = _0x30e838(_0x32c4eb, _0x421f29, _0xb7e02e, _0x5ef7cd, _0x258713, _0x1a2712, _0x2a0a33);
    _0x30e838(_0x32c4eb, _0x37a577, _0x15a2d3, _0x5ef7cd, _0x258713, _0x1a2712, _0x2a0a33);
    _0x30e838(_0x32c4eb, _0x4ff0dd, _0x2748fe, _0x5ef7cd, _0x258713, _0x1a2712, _0x2a0a33);
    if (!_0x5cc587) {
      _0x32c4eb.indexCount += 6;
      return;
    }
    let _0x1e56db = _0x32c4eb.indexCount;
    _0x32c4eb.indices[_0x1e56db++] = _0x3f186e;
    _0x32c4eb.indices[_0x1e56db++] = _0x3f186e + 1;
    _0x32c4eb.indices[_0x1e56db++] = _0x3f186e + 2;
    _0x32c4eb.indices[_0x1e56db++] = _0x3f186e + 2;
    _0x32c4eb.indices[_0x1e56db++] = _0x3f186e + 1;
    _0x32c4eb.indices[_0x1e56db++] = _0x3f186e;
    _0x32c4eb.indexCount = _0x1e56db;
  }
  function _0x40ac48(_0xb8e8dc, _0x1bbced, _0x222935, _0x3e31c6, _0x4183b7, _0xec75a7, _0x268398, _0x2d67f0, _0x29203f, _0x473603, _0xbe7ff8, _0x180f19, _0x505790, _0x5ac274) {
    let _0x2d64a6 = _0x30e838(_0xb8e8dc, _0x222935, _0x3e31c6, _0xbe7ff8, _0x180f19, _0x505790, _0x5ac274);
    _0x30e838(_0xb8e8dc, _0x4183b7, _0xec75a7, _0xbe7ff8, _0x180f19, _0x505790, _0x5ac274);
    _0x30e838(_0xb8e8dc, _0x268398, _0x2d67f0, _0xbe7ff8, _0x180f19, _0x505790, _0x5ac274);
    _0x30e838(_0xb8e8dc, _0x29203f, _0x473603, _0xbe7ff8, _0x180f19, _0x505790, _0x5ac274);
    if (!_0x1bbced) {
      _0xb8e8dc.indexCount += 12;
      return;
    }
    let _0x2186f8 = _0xb8e8dc.indexCount;
    _0xb8e8dc.indices[_0x2186f8++] = _0x2d64a6;
    _0xb8e8dc.indices[_0x2186f8++] = _0x2d64a6 + 1;
    _0xb8e8dc.indices[_0x2186f8++] = _0x2d64a6 + 2;
    _0xb8e8dc.indices[_0x2186f8++] = _0x2d64a6;
    _0xb8e8dc.indices[_0x2186f8++] = _0x2d64a6 + 2;
    _0xb8e8dc.indices[_0x2186f8++] = _0x2d64a6 + 3;
    _0xb8e8dc.indices[_0x2186f8++] = _0x2d64a6 + 2;
    _0xb8e8dc.indices[_0x2186f8++] = _0x2d64a6 + 1;
    _0xb8e8dc.indices[_0x2186f8++] = _0x2d64a6;
    _0xb8e8dc.indices[_0x2186f8++] = _0x2d64a6 + 3;
    _0xb8e8dc.indices[_0x2186f8++] = _0x2d64a6 + 2;
    _0xb8e8dc.indices[_0x2186f8++] = _0x2d64a6;
    _0xb8e8dc.indexCount = _0x2186f8;
  }
  function _0x3b350e(_0x582bb4, _0x87265a, _0x3cc50a, _0x1c6ad3, _0x4741cc, _0x5cdbcf, _0x125dec, _0x18b428, _0x338f5f, _0x3b6b99) {
    let _0x140923 = _0x5cdbcf.length / 2;
    for (let _0x165a44 = 0; _0x165a44 < _0x140923; _0x165a44++) {
      let _0x2bb243 = _0x165a44 + 1 === _0x140923 ? 0 : _0x165a44 + 1;
      _0x470fa2(_0x582bb4, _0x87265a, _0x3cc50a, _0x1c6ad3, _0x3cc50a + _0x4741cc * _0x5cdbcf[_0x165a44 * 2], _0x1c6ad3 + _0x4741cc * _0x5cdbcf[_0x165a44 * 2 + 1], _0x3cc50a + _0x4741cc * _0x5cdbcf[_0x2bb243 * 2], _0x1c6ad3 + _0x4741cc * _0x5cdbcf[_0x2bb243 * 2 + 1], _0x125dec, _0x18b428, _0x338f5f, _0x3b6b99);
    }
  }
  function _0x56901d(_0x3e335d, _0x24e012, _0x4278c5, _0x1c2625, _0x2f8087, _0x5d97be, _0x11b2cb, _0x286d02, _0x48bbe3) {
    let _0x4c89e3 = Math.max(0, _0x4278c5 - _0x1c2625 * 0.5);
    let _0x6faa7c = _0x4278c5 + _0x1c2625 * 0.5;
    let _0x4dbd2a = _0x2f8087.length / 2;
    for (let _0x341572 = 0; _0x341572 < _0x4dbd2a; _0x341572++) {
      let _0x50487a = _0x341572 + 1 === _0x4dbd2a ? 0 : _0x341572 + 1;
      let _0x2b5a35 = _0x2f8087[_0x341572 * 2];
      let _0x3f181e = _0x2f8087[_0x341572 * 2 + 1];
      let _0x5825ff = _0x2f8087[_0x50487a * 2];
      let _0x2bb9d8 = _0x2f8087[_0x50487a * 2 + 1];
      _0x40ac48(_0x3e335d, _0x24e012, _0x4c89e3 * _0x2b5a35, _0x4c89e3 * _0x3f181e, _0x6faa7c * _0x2b5a35, _0x6faa7c * _0x3f181e, _0x6faa7c * _0x5825ff, _0x6faa7c * _0x2bb9d8, _0x4c89e3 * _0x5825ff, _0x4c89e3 * _0x2bb9d8, _0x5d97be, _0x11b2cb, _0x286d02, _0x48bbe3);
    }
  }
  function _0x17f5de(_0x35dc50, _0x31bb14, _0x1a6021) {
    _0x35dc50.vertexCount += _0x31bb14;
    _0x35dc50.indexCount += _0x1a6021;
  }
  function _0x4d3530(_0x55d2dc, _0x5f009e, _0x2e5640, _0x154470, _0x41c68) {
    _0x55d2dc.vertexCount = 0;
    _0x55d2dc.indexCount = 0;
    let _0x5330a0 = Math.max(0, _0x2e5640) / 1000;
    let _0x357e55 = _0x3954cb * _0x5330a0 * Math.PI / 180;
    let _0x2f26d6 = _0x32efb8 * _0x5330a0 % 1;
    let _0x5156b0 = _0x5f009e.radius;
    let _0x5c027d = _0x5f009e.rgba[0];
    let _0x37dfaf = _0x5f009e.rgba[1];
    let _0x38efae = _0x5f009e.rgba[2];
    if (_0x41c68) {
      _0x3b350e(_0x55d2dc, _0x154470, 0, 0, _0x5156b0, _0x467e95, _0x5c027d, _0x37dfaf, _0x38efae, _0x151610(_0x5f009e.rgba, 0.08));
    } else {
      _0x17f5de(_0x55d2dc, 144, 288);
    }
    let _0x589234 = Math.max(0.08, _0x5156b0 * 0.003);
    if (_0x41c68) {
      for (let _0x1185a6 = 0; _0x1185a6 < 16; _0x1185a6++) {
        let _0x2c3c84 = _0x58f97c[_0x1185a6 * 2];
        let _0x5942b7 = _0x58f97c[_0x1185a6 * 2 + 1];
        let _0x26772a = -_0x5942b7 * _0x589234;
        let _0x125777 = _0x2c3c84 * _0x589234;
        _0x40ac48(_0x55d2dc, _0x154470, _0x26772a, _0x125777, -_0x26772a, -_0x125777, _0x5156b0 * _0x2c3c84 - _0x26772a, _0x5156b0 * _0x5942b7 - _0x125777, _0x5156b0 * _0x2c3c84 + _0x26772a, _0x5156b0 * _0x5942b7 + _0x125777, _0x5c027d, _0x37dfaf, _0x38efae, _0x151610(_0x5f009e.rgba, 0.19));
      }
    } else {
      _0x17f5de(_0x55d2dc, 64, 192);
    }
    let _0x504c3e = Math.max(0.1, _0x5156b0 * 0.006);
    if (_0x41c68) {
      _0x56901d(_0x55d2dc, _0x154470, _0x5156b0 * 0.25, _0x504c3e, _0x3cee8f, _0x5c027d, _0x37dfaf, _0x38efae, _0x151610(_0x5f009e.rgba, 0.18));
      _0x56901d(_0x55d2dc, _0x154470, _0x5156b0 * 0.5, _0x504c3e, _0x3cee8f, _0x5c027d, _0x37dfaf, _0x38efae, _0x151610(_0x5f009e.rgba, 0.21));
      _0x56901d(_0x55d2dc, _0x154470, _0x5156b0 * 0.75, _0x504c3e, _0x3cee8f, _0x5c027d, _0x37dfaf, _0x38efae, _0x151610(_0x5f009e.rgba, 0.24));
    } else {
      _0x17f5de(_0x55d2dc, 384, 1152);
    }
    for (let _0x1707d8 = 0; _0x1707d8 < _0xc6595e; _0x1707d8++) {
      let _0x1d294d = _0x1707d8 / _0xc6595e;
      let _0xf85d4 = (_0x1707d8 + 1) / _0xc6595e;
      let _0x202252 = _0x357e55 - _0x44152d + _0x44152d * _0x1d294d;
      let _0xa2284a = _0x357e55 - _0x44152d + _0x44152d * _0xf85d4;
      let _0x4f6500 = Math.cos(_0x202252);
      let _0x3a61b6 = Math.sin(_0x202252);
      let _0x3b306f = Math.cos(_0xa2284a);
      let _0x51cd19 = Math.sin(_0xa2284a);
      _0x40ac48(_0x55d2dc, _0x154470, _0x5156b0 * 0.84 * _0x4f6500, _0x5156b0 * 0.84 * _0x3a61b6, _0x5156b0 * _0x4f6500, _0x5156b0 * _0x3a61b6, _0x5156b0 * _0x3b306f, _0x5156b0 * _0x51cd19, _0x5156b0 * 0.84 * _0x3b306f, _0x5156b0 * 0.84 * _0x51cd19, _0x5c027d, _0x37dfaf, _0x38efae, _0x151610(_0x5f009e.rgba, 0.03 + _0xf85d4 * 0.45 * _0xf85d4));
    }
    let _0x45cfcb = _0x5156b0 * Math.cos(_0x357e55);
    let _0x27b322 = _0x5156b0 * Math.sin(_0x357e55);
    _0x3b350e(_0x55d2dc, _0x154470, _0x45cfcb, _0x27b322, Math.max(1.2, _0x5156b0 * 0.05), _0x45fabc, _0x5c027d, _0x37dfaf, _0x38efae, _0x151610(_0x5f009e.rgba, 0.2));
    _0x3b350e(_0x55d2dc, _0x154470, _0x45cfcb, _0x27b322, Math.max(0.4, _0x5156b0 * 0.018), _0xf00c2, _0x5c027d, _0x37dfaf, _0x38efae, _0x151610(_0x5f009e.rgba, 0.88));
    if (_0x41c68) {
      _0x56901d(_0x55d2dc, _0x154470, _0x5156b0 - _0x5156b0 * 0.008, Math.max(0.18, _0x5156b0 * 0.012), _0x467e95, _0x5c027d, _0x37dfaf, _0x38efae, _0x151610(_0x5f009e.rgba, 0.1));
      _0x56901d(_0x55d2dc, _0x154470, _0x5156b0 + _0x5156b0 * 0.008, Math.max(0.18, _0x5156b0 * 0.012), _0x467e95, _0x5c027d, _0x37dfaf, _0x38efae, _0x151610(_0x5f009e.rgba, 0.1));
      _0x56901d(_0x55d2dc, _0x154470, _0x5156b0, Math.max(0.12, _0x5156b0 * 0.007), _0x467e95, _0x5c027d, _0x37dfaf, _0x38efae, _0x151610(_0x5f009e.rgba, 0.73));
    } else {
      _0x17f5de(_0x55d2dc, 576, 1728);
    }
    let _0x42876a = _0x5156b0 * (0.12 + _0x2f26d6 * 0.88);
    let _0x5ede3b = (1 - _0x2f26d6) * 0.57;
    _0x56901d(_0x55d2dc, _0x154470, _0x42876a, Math.max(0.3, _0x5156b0 * 0.018), _0x467e95, _0x5c027d, _0x37dfaf, _0x38efae, _0x151610(_0x5f009e.rgba, _0x5ede3b / 3));
    _0x56901d(_0x55d2dc, _0x154470, _0x42876a, Math.max(0.12, _0x5156b0 * 0.007), _0x467e95, _0x5c027d, _0x37dfaf, _0x38efae, _0x151610(_0x5f009e.rgba, _0x5ede3b));
    if (_0x55d2dc.vertexCount !== _0x12337a || _0x55d2dc.indexCount !== _0x7645e2) {
      throw new Error("Radar mesh topology count changed");
    }
    if (_0x41c68) {
      _0x55d2dc.staticRadius = _0x5156b0;
      _0x55d2dc.staticR = _0x5c027d;
      _0x55d2dc.staticG = _0x37dfaf;
      _0x55d2dc.staticB = _0x38efae;
      _0x55d2dc.staticA = _0x5f009e.rgba[3];
    }
  }
  function _0x11e13(_0x26fe77, _0x7f1282) {
    let _0x3dbe31 = {
      positions: new Float32Array(_0x12337a * 3),
      colours: new Float32Array(_0x12337a * 4),
      indices: new Int32Array(_0x7645e2),
      vertexCount: 0,
      indexCount: 0,
      staticRadius: Number.NaN,
      staticR: Number.NaN,
      staticG: Number.NaN,
      staticB: Number.NaN,
      staticA: Number.NaN
    };
    _0x4d3530(_0x3dbe31, _0x26fe77, _0x7f1282, true, true);
    return _0x3dbe31;
  }
  function _0x25c7bb(_0x5ae71f, _0x309bfc, _0x6f80e9) {
    let _0x3ba329 = _0x5ae71f.staticRadius !== _0x309bfc.radius || _0x5ae71f.staticR !== _0x309bfc.rgba[0] || _0x5ae71f.staticG !== _0x309bfc.rgba[1] || _0x5ae71f.staticB !== _0x309bfc.rgba[2] || _0x5ae71f.staticA !== _0x309bfc.rgba[3];
    _0x4d3530(_0x5ae71f, _0x309bfc, _0x6f80e9, false, _0x3ba329);
  }
  var KEYS_RADAR = ["rvaZoomLateUpdate", "tiRadarVector3Array", "tiRadarColorArray", "tiRadarIntArray"];
  function _0x57fe36() {
    return {
      attach: (_0x456185, _0x3275fe) => Interceptor.attach(_0x456185, _0x3275fe)
    };
  }
  function _0x5e4fdf(_0x46a7b8) {
    for (let _0x223bfd of KEYS_RADAR) {
      let _0x4a4760 = _0x46a7b8[_0x223bfd];
      if (typeof _0x4a4760 != "number" || !Number.isInteger(_0x4a4760) || _0x4a4760 <= 0) {
        return null;
      }
    }
    return _0x46a7b8;
  }
  function _0x2e1623(_0x519501, _0x12d62b) {
    if (_0x519501 === null) {
      return _0x12d62b === null;
    } else {
      return _0x12d62b !== null && _0x519501.x === _0x12d62b.x && _0x519501.y === _0x12d62b.y && _0x519501.z === _0x12d62b.z;
    }
  }
  function _0x553e3a(_0x276792, _0x51a5af) {
    return _0x276792.staticRadius !== _0x51a5af.radius || _0x276792.staticR !== _0x51a5af.rgba[0] || _0x276792.staticG !== _0x51a5af.rgba[1] || _0x276792.staticB !== _0x51a5af.rgba[2] || _0x276792.staticA !== _0x51a5af.rgba[3];
  }
  var _0x4845d1 = class {
    access;
    native;
    now;
    defer;
    animate;
    zones = new Map();
    pendingDestroy = [];
    lateUpdateHook = null;
    detachScheduled = false;
    ready = false;
    disposed = false;
    errorReported = false;
    reason = "Radar is not initialized";
    drawFrames = 0;
    drawTotalMs = 0;
    drawLastMs = 0;
    drawMaxMs = 0;
    frameDrawing = false;
    constructor(_0x2af4f6) {
      this.access = _0x2af4f6;
      this.native = _0x2af4f6.native ?? _0x57fe36();
      this.now = _0x2af4f6.now ?? (() => Date.now());
      this.defer = _0x2af4f6.defer ?? (_0x234d3a => {
        setImmediate(_0x234d3a);
      });
      this.animate = _0x2af4f6.animate !== false;
      this.initialize();
    }
    available() {
      return this.ready && !this.disposed;
    }
    active() {
      return this.available() && this.zones.size > 0;
    }
    command(_0xee09b8) {
      let _0x5ea5a8 = _0x5b4212(_0xee09b8);
      let _0x2de7fb = typeof _0xee09b8?.id == "string" && _0xee09b8.id.length > 0 ? _0xee09b8.id : "default";
      if (!_0x5ea5a8.ok) {
        this.reply(_0x2de7fb, false, _0x5ea5a8.error);
        return;
      }
      if (!this.available()) {
        this.reply(_0x5ea5a8.command.id, false, this.reason);
        return;
      }
      let _0x52067a = _0x5ea5a8.command;
      if (_0x52067a.kind === "hide") {
        let _0x103362 = this.zones.get(_0x52067a.id);
        if (_0x103362 !== undefined) {
          this.destroyZone(_0x103362);
        }
        this.zones.delete(_0x52067a.id);
        this.reply(_0x52067a.id, true, "");
        return;
      }
      if (_0x52067a.kind === "resize") {
        let _0x3e672f = this.zones.get(_0x52067a.id);
        if (_0x3e672f === undefined) {
          this.reply(_0x52067a.id, false, "Radar zone not found: " + _0x52067a.id);
          return;
        }
        _0x3e672f.radius = _0x52067a.radius;
        _0x3e672f.reportedDraw = false;
        _0x3e672f.drawn = false;
        this.reply(_0x52067a.id, true, "");
        return;
      }
      let _0x45ae8f = this.zones.get(_0x52067a.id);
      if (_0x45ae8f !== undefined && !_0x2e1623(_0x45ae8f.fixed, _0x52067a.fixed)) {
        this.destroyZone(_0x45ae8f);
        this.zones.delete(_0x52067a.id);
      }
      let _0x24289e = this.zones.get(_0x52067a.id);
      if (_0x24289e !== undefined) {
        _0x24289e.radius = _0x52067a.radius;
        _0x24289e.rgba = _0x52067a.rgba;
        _0x24289e.reportedDraw = false;
        _0x24289e.drawn = false;
      } else {
        this.zones.set(_0x52067a.id, {
          ..._0x52067a,
          animationStartMs: this.now(),
          frame: null,
          handle: null,
          reportedDraw: false,
          drawn: false,
          visible: false
        });
      }
      this.errorReported = false;
      this.reply(_0x52067a.id, true, "");
    }
    status() {
      let _0x16441f = false;
      let _0x5b2e89 = false;
      let _0x2f0704 = false;
      if (this.available()) {
        for (let _0x82b573 of this.zones.values()) {
          if (_0x82b573.drawn) {
            _0x16441f = true;
          }
          if (_0x82b573.handle === null) {
            _0x5b2e89 = true;
          } else if (!_0x82b573.drawn) {
            _0x2f0704 = true;
          }
        }
      }
      return {
        ready: this.available(),
        reason: this.reason,
        draw: _0x16441f,
        material: _0x5b2e89 ? "pending" : _0x16441f ? "ready" : _0x2f0704 ? "retained" : "idle",
        zones: Array.from(this.zones.keys()),
        count: this.zones.size,
        drawFrames: this.drawFrames,
        drawTotalMs: this.drawTotalMs,
        drawLastMs: this.drawLastMs,
        drawMaxMs: this.drawMaxMs,
        drawMeanMs: this.drawFrames === 0 ? 0 : this.drawTotalMs / this.drawFrames
      };
    }
    stop() {
      for (let _0x59ca67 of this.zones.values()) {
        this.destroyZone(_0x59ca67);
      }
      this.zones.clear();
      this.errorReported = false;
    }
    dispose() {
      if (!this.disposed) {
        this.disposed = true;
        this.ready = false;
        this.stop();
        if (this.pendingDestroy.length === 0) {
          this.scheduleDetachHook();
        }
      }
    }
    initialize() {
      let off = _0x5e4fdf(this.access.offsets);
      if (off === null) {
        this.reason = "Radar offsets are missing";
        return;
      }
      let _0x173e9f = this.access.codeSite(off.rvaZoomLateUpdate, "Zoom.LateUpdate");
      if (typeof _0x173e9f == "string") {
        this.reason = _0x173e9f;
        return;
      }
      try {
        this.lateUpdateHook = this.native.attach(_0x173e9f, {
          onLeave: () => this.afterLateUpdate()
        });
        this.ready = true;
        this.reason = "";
      } catch (_0x42cdce) {
        this.reason = "Radar initialization failed: " + _0x42cdce;
        this.detachHook();
      }
    }
    afterLateUpdate() {
      if (!this.frameDrawing) {
        this.frameDrawing = true;
        try {
          this.drainDestroy();
          if (this.disposed) {
            this.scheduleDetachHook();
            return;
          }
          if (!this.available() || this.zones.size === 0) {
            return;
          }
          let _0x11b986 = this.now();
          let _0x359c2b = false;
          try {
            let _0x1cb3bc = this.access.getSnapshot();
            for (let _0x6a4c26 of this.zones.values()) {
              _0x6a4c26.drawn = false;
              let _0x47f8ed = _0x6a4c26.handle;
              if (_0x51b8f4(_0x1cb3bc, _0x6a4c26.fixed) === null) {
                if (_0x47f8ed !== null && _0x6a4c26.visible) {
                  this.access.mesh.setVisible(_0x47f8ed, false);
                  _0x6a4c26.visible = false;
                }
                this.reason = "Radar self snapshot is unavailable, loading, or stale";
                continue;
              }
              let _0x4e13ac = this.animate ? this.now() - _0x6a4c26.animationStartMs : 0;
              let _0x4399da = false;
              if (_0x6a4c26.frame === null) {
                _0x6a4c26.frame = _0x11e13(_0x6a4c26, _0x4e13ac);
              } else if (this.animate || _0x553e3a(_0x6a4c26.frame, _0x6a4c26)) {
                _0x25c7bb(_0x6a4c26.frame, _0x6a4c26, _0x4e13ac);
                _0x4399da = true;
              }
              if (_0x47f8ed === null) {
                let _0x126e80 = this.access.mesh.create(_0x6a4c26.id, _0x6a4c26.frame, _0x6a4c26.fixed);
                if (typeof _0x126e80 == "string") {
                  throw new Error(_0x126e80);
                }
                if (this.zones.get(_0x6a4c26.id) !== _0x6a4c26) {
                  this.pendingDestroy.push(_0x126e80);
                  continue;
                }
                _0x6a4c26.handle = _0x126e80;
                _0x6a4c26.visible = true;
              } else {
                if (_0x4399da && (this.access.mesh.update(_0x47f8ed, _0x6a4c26.frame), this.zones.get(_0x6a4c26.id) !== _0x6a4c26 || _0x6a4c26.handle !== _0x47f8ed)) {
                  continue;
                }
                if (!_0x6a4c26.visible) {
                  this.access.mesh.setVisible(_0x47f8ed, true);
                  _0x6a4c26.visible = true;
                }
              }
              _0x6a4c26.drawn = true;
              _0x359c2b = true;
              if (!_0x6a4c26.reportedDraw) {
                _0x6a4c26.reportedDraw = true;
                this.access.send({
                  t: "zone",
                  layout: "radar",
                  id: _0x6a4c26.id,
                  ok: true,
                  draw: true,
                  material: "ready",
                  event: "first_draw"
                });
              }
            }
            if (_0x359c2b) {
              this.reason = "";
            }
          } catch (_0xa79be6) {
            this.reason = "Radar mesh update failed: " + _0xa79be6;
            this.reportFirstError("*", this.reason);
            this.stop();
          }
          this.drainDestroy();
          if (_0x359c2b) {
            let _0x5227db = Math.max(0, this.now() - _0x11b986);
            this.drawFrames++;
            this.drawTotalMs += _0x5227db;
            this.drawLastMs = _0x5227db;
            if (_0x5227db > this.drawMaxMs) {
              this.drawMaxMs = _0x5227db;
            }
          }
        } finally {
          this.frameDrawing = false;
        }
      }
    }
    destroyZone(_0x83160f) {
      if (_0x83160f.handle !== null) {
        this.pendingDestroy.push(_0x83160f.handle);
        _0x83160f.handle = null;
        _0x83160f.drawn = false;
        _0x83160f.visible = false;
      }
    }
    drainDestroy() {
      for (let _0x31f0e1 = 0; _0x31f0e1 < this.pendingDestroy.length; _0x31f0e1++) {
        try {
          this.access.mesh.destroy(this.pendingDestroy[_0x31f0e1]);
        } catch {}
      }
      this.pendingDestroy.length = 0;
    }
    reportFirstError(_0x3c7c6f, _0x6d705b) {
      if (!this.errorReported) {
        this.errorReported = true;
        this.access.send({
          t: "zone",
          layout: "radar",
          id: _0x3c7c6f,
          ok: false,
          draw: false,
          material: "failed",
          event: "first_error",
          error: _0x6d705b
        });
      }
    }
    reply(_0x3f9c7c, _0x5d1d53, _0x28260b) {
      let _0x17ceb5 = {
        t: "zone",
        layout: "radar",
        id: _0x3f9c7c,
        ok: _0x5d1d53,
        draw: false,
        material: this.zones.get(_0x3f9c7c)?.handle === null ? "pending" : "idle"
      };
      if (_0x28260b.length > 0) {
        _0x17ceb5.error = _0x28260b;
      }
      this.access.send(_0x17ceb5);
    }
    detachHook() {
      this.diagnoseCleanup("detach_before");
      if (this.lateUpdateHook !== null) {
        try {
          this.lateUpdateHook.detach();
        } catch {}
        this.lateUpdateHook = null;
      }
      this.diagnoseCleanup("detach_after");
    }
    scheduleDetachHook() {
      if (this.lateUpdateHook !== null && !this.detachScheduled) {
        this.detachScheduled = true;
        this.defer(() => {
          this.detachScheduled = false;
          this.detachHook();
        });
      }
    }
    diagnoseCleanup(_0x307129) {
      try {
        this.access.trace?.("radar cleanup " + _0x307129);
      } catch {}
    }
  };
  function _0x38f334(_0x2b2cc2) {
    return new _0x4845d1(_0x2b2cc2);
  }
  function _0x1e0777(_0x536199) {
    return _0x536199 !== null && typeof _0x536199 == "object" && _0x536199.id === "player" && _0x536199.renderer === "radar" && ["w", "x2", "y2", "z2"].every(_0x21f374 => _0x536199[_0x21f374] === undefined);
  }
  var KEYS_CORE = ["module", "unityVersion", "versionCode", "rvaHandlerUpdate", "rvaFrameMove", "rvaOnManualMovement", "arrCount", "arrFirst", "arrStride", "strLen", "strChars", "phPlayers", "phCrows", "phItems", "phMoney", "pcCharLogic", "pcActorMove", "pcTarget", "pcManualTarget", "pcManualActive", "pcAction", "pcActState", "pcJoystick", "gaPosition", "gaVelocity", "gaMaxSpeed", "gaCorner", "gaPathActive", "gaHasDirect", "gaDirectTarget", "clSkillFact", "clSystemBuff", "clQItemFact", "qfTime", "clHp", "clMp", "clSp", "clCombat", "clLevel", "clMoney", "crowId", "crowDataId", "crowController", "aiCrowLogic", "aiActor", "aiIsDead", "aiMobNpc", "crowNowHp", "defName", "defBoss", "defType", "defData", "defHp", "defLevel", "mobMain", "mobSub", "unitGaeaId", "unitClient", "unitIsSelf", "unitParty", "unitSchool", "unitClass", "unitMaster", "unitName", "ccActor", "ccTarget", "ccCharData", "ccSkillFacts", "targetCrowType", "targetId", "sdHp", "sdLevel", "sdName", "itemData", "itemItem", "dropPos", "dropId", "dropInfo", "sitemNativeId", "sitemTurn", "itemObjName", "itemObjType", "itemObjQuestion", "itemQuestionType", "goldData", "moneyPos", "moneyId", "moneyAmount", "sfStride", "sfAge", "sfLevel", "sfNativeId"];
  var KEYS_MESH = ["rvaMeshCtor", "rvaMeshGetVertexCount", "rvaMeshFilterSetMesh", "rvaRendererSetMaterial", "rvaRendererSetEnabled", "rvaGameObjectCtor", "rvaGameObjectAddComponent", "rvaGameObjectGetLayer", "rvaGameObjectSetLayer", "rvaComponentGetTransform", "rvaTransformSetParent", "rvaTransformSetLocalPosInjected", "rvaTransformGetLossyScaleInjected", "rvaObjectDestroy", "rvaComponentGetGameObject", "rvaMeshSetVertices", "rvaMeshSetTriangles", "rvaMeshSetColors", "rvaShaderFind", "rvaMaterialCtor", "strideV3", "strideColor", "strideInt", "objCachedPtr"];
  var KEYS_WORLD_TO_SCREEN = ["rvaW2sPoint", "rvaScreenWidth", "rvaScreenHeight", "rvaCameraMain", "eyeMono", "objCachedPtr"];
  var KEYS_FOG = ["rvaFogSettings", "rvaFogGet", "rvaFogSet", "rvaZoomLateUpdate", "objCachedPtr"];
  var KEYS_ZOOM = ["rvaZoomUpdate", "rvaZoomClamp", "rvaZoomLateUpdate", "camDeltaHeight0", "camDeltaRadius0", "camDeltaRadius1", "camDeltaRadius2", "camWasHeight0", "camWasRadius0", "camWasRadius1", "camWasRadius2", "objCachedPtr", "zoomCineCam", "zoomHeights", "zoomRadii", "camBindingMode", "camHeading", "camRecenterTilt", "camRecenterHeading"];
  var KEYS_RADAR2 = ["tiRadarVector3Array", "tiRadarColorArray", "tiRadarIntArray", "rvaMeshSetVertices", "rvaMeshSetTriangles", "rvaMeshSetColors", "rvaZoomLateUpdate", "objCachedPtr"];
  var KEYS_QUICKSLOT = ["rvaSlotAnchor", "rvaSlotContainer", "rvaSlotGetSlots", "rvaSlotUse", "slotMax", "slotItem", "slotAmount"];
  var KEYS_ATTACK = ["rvaAtkSetTarget", "rvaAtkSetEnemy", "rvaAtkPress", "rvaAtkCancel", "rvaAtkGetCrow", "rvaComponentGetGameObject", "rvaAtkAnchor", "crowMob", "crowIdMax", "ecPfta"];
  var KEYS_SKILL = ["rvaSkillBarAnchor", "rvaSkillCheck", "rvaSkillCast", "rvaSkillGetObject", "icSkillHotkey", "swoContainer", "swoTabIndex", "swSlots", "ssSkill", "ssSkillData", "skMainId", "skSubId", "sbName", "pcSkillData", "uisSkillWindow"];
  var KEYS_PICKUP = ["rvaPickSend", "rvaPickAnchor", "crowItem", "crowMoney"];
  var KEYS_NPC_SALE = ["rvaNpcSaleRequest"];
  var KEYS_RECALL = ["rvaRecallCardRequest"];
  var KEYS_FRIEND_WARP = ["rvaFriendMoveRequest"];
  var KEYS_MATERIAL = ["rvaMaterialSetRenderQueue", "rvaMaterialSetInt"];
  var KEYS_QBOX = ["rvaGetComponentsInternal", "tiQBoxFunction", "tiImage", "objCachedPtr", "klassStaticFields", "sfQBoxInstance", "qbIndicator", "imgFillAmount"];
  var KEYS_CHAR_SELECT = ["tiGameDataManager", "klassStaticFields", "sfGdmInstance", "gdmCharSelect", "csId"];
  var KEYS_SKILL_TAB = ["rvaSwitchToTab", "tiSkillTabManager", "swoTabIndex", "klassStaticFields", "sfSkillTabInstance", "pcCastPending", "sdToMove"];
  var KEYS_INVENTORY = ["rvaBagGetItemObject", "tiInstanceContainer", "slotItem", "slotAmount", "klassStaticFields", "icInstance", "icInventory", "icEquipment", "ioContainer", "invSlots", "slotItemPos", "slotIndex", "itemMainId", "itemSubId", "itemObjWearPos", "itemObjMaxPile", "phInvenLine"];
  var KEYS_BOT_CHALLENGE = ["rvaChallengeIncoming", "rvaChallengeSubmission", "rvaChallengeResult", "rvaPickAnchor", "scmZoneConnection", "bcChallengeId", "bcChallengeType", "bcTimeoutSec", "bcAttemptsLeft", "bcImageLen", "bcImage", "bcrChallengeId", "bcrResult", "bcrAttemptsLeft"];
  var KEYS_SCENE_LOADER = ["tiMultiSceneHelper", "rvaBehaviourGetEnabled", "klassStaticFields", "mshInstance", "mshLoader", "mshFirstLoader", "loaderCanvas"];
  var KEYS_REBIRTH = ["rvaIsGenuinelyDead", "rvaLandIsTyranny", "rvaIsConfronting", "rvaIsInPostConfrontGrace", "rvaSendRebirth", "rvaHasValidRosary", "rvaPickAnchor", "tiInstanceContainer", "klassStaticFields", "icInstance", "icEquipment", "scmZoneConnection"];
  var KEYS_CLIENT = ["tiClient", "klassStaticFields", "sfClientInstance", "clientUserId"];
  var KEYS_FRIENDS = ["tiCharacterFriendManager", "rvaGetFriends", "klassStaticFields", "sfFriendMgrInstance", "fmFriends", "fmListLoaded", "fceName", "fceId", "fceFlag", "fceOnline", "fceKnown", "fceChannel", "fceLevel", "fceClass", "fceSchool", "fceStride", "listItems", "listSize"];
  var KEYS_PARTY = ["tiPartyManager", "rvaPartyMemberCount", "rvaPartyMemberPlayerId", "rvaPlayerGetPlayer", "rvaSelectRemotePlayer", "rvaSelectSelf", "rvaAtkAnchor", "partyInstance", "unitSelf", "klassStaticFields"];
  var KEYS_OPTIONAL = ["targetCrowType", "partyInstance", "sfClientInstance", "mshInstance", "sfQBoxInstance", "sfGdmInstance", "sfSkillTabInstance", "icInstance", "sfFriendMgrInstance", "fceId"];
  function _0x5a8e4e(_0x3d6a74) {
    return !_0x3d6a74.isNull() && _0x3d6a74.and(1).isNull();
  }
  function _0x5bc88a(_0xbcd78f, _0x303dc4, _0x3fde68) {
    if (!Number.isSafeInteger(_0x303dc4) || _0x303dc4 <= 0 || _0x3fde68 !== 4 && _0x3fde68 !== 8) {
      return false;
    } else {
      return _0xbcd78f.every(_0x23110e => Number.isSafeInteger(_0x23110e) && _0x23110e > 0 && _0x23110e % _0x3fde68 === 0 && _0x23110e + _0x3fde68 <= _0x303dc4);
    }
  }
  function _0x334def(_0x31b534) {
    return (_0x31b534 == null ? "" : String(_0x31b534)).slice(0, 1000);
  }
  var _0x57ef97 = class {
    generation = 0;
    activeGeneration = 0;
    nextPollAtMs = 0;
    begin(_0x35652d) {
      this.generation++;
      this.activeGeneration = this.generation;
      this.nextPollAtMs = _0x35652d + 500;
      return this.activeGeneration;
    }
    claimPoll(_0x4786b3, _0x28296a) {
      if (_0x4786b3 !== this.activeGeneration || _0x28296a < this.nextPollAtMs) {
        return false;
      } else {
        this.nextPollAtMs = _0x28296a + 500;
        return true;
      }
    }
    finish(_0x2a0f5c) {
      if (_0x2a0f5c !== this.activeGeneration) {
        return false;
      } else {
        this.activeGeneration = 0;
        this.nextPollAtMs = 0;
        return true;
      }
    }
    cancel() {
      this.generation++;
      this.activeGeneration = 0;
      this.nextPollAtMs = 0;
    }
  };
  var _0x29fc38 = [70, 30, 0];
  var _0x63492a = [40, 80, 80];
  var _0x22e576 = _0x63492a[1];
  var _0x14727d = 200;
  function _0x5baffb(_0x1d6f58) {
    if (typeof _0x1d6f58 == "number" && Number.isInteger(_0x1d6f58) && _0x1d6f58 > 0 && _0x1d6f58 <= 4294967295) {
      return _0x1d6f58;
    } else {
      return null;
    }
  }
  function _0x1218d2(_0x412d7c) {
    let _0x167504 = _0x5baffb(_0x412d7c?.req);
    if (_0x167504 === null) {
      return {
        ok: false,
        error: "Camera zoom request id must be a positive unsigned integer",
        req: 0
      };
    }
    let _0x7f72c4 = _0x412d7c.zoom;
    if (typeof _0x7f72c4 != "number" || !Number.isFinite(_0x7f72c4) || _0x7f72c4 <= 0) {
      return {
        ok: false,
        error: "Camera zoom multiplier must be finite and positive",
        req: _0x167504
      };
    } else if ([..._0x29fc38, ..._0x63492a].filter(_0xffc89e => _0xffc89e > 0).map(_0x3d4ee6 => Math.fround(_0x3d4ee6 * _0x7f72c4)).some(_0xbdb195 => !Number.isFinite(_0xbdb195) || _0xbdb195 <= 0)) {
      return {
        ok: false,
        error: "Camera zoom multiplier cannot be represented by Float32 native targets",
        req: _0x167504
      };
    } else {
      return {
        ok: true,
        zoom: _0x7f72c4,
        req: _0x167504
      };
    }
  }
  function _0x5618c4(_0x4ba87c) {
    return {
      heights: _0x29fc38.map(_0x2e5a46 => _0x2e5a46 * _0x4ba87c),
      radii: _0x63492a.map(_0x51938c => _0x51938c * _0x4ba87c)
    };
  }
  function _0x2ab6f1(_0x3f08be) {
    if (_0x3f08be.length < 2 || !Number.isFinite(_0x3f08be[1])) {
      return null;
    } else {
      return _0x3f08be[1] / _0x22e576;
    }
  }
  var _0x48fc5d = 0.0005;
  function _0x24dace(_0x1b2f64) {
    if (_0x1b2f64.heights.length < 3 || _0x1b2f64.radii.length < 3) {
      return "camera zoom native arrays contain fewer than three values";
    }
    for (let _0x560a20 = 0; _0x560a20 < 3; _0x560a20++) {
      if (!Number.isFinite(_0x1b2f64.heights[_0x560a20]) || !Number.isFinite(_0x1b2f64.radii[_0x560a20])) {
        return "camera zoom native arrays contain a non-finite value";
      }
    }
    return null;
  }
  function _0x2a00b0(_0x2f1d83, _0x4be9ef) {
    for (let _0x26602b = 0; _0x26602b < 3; _0x26602b++) {
      let _0x185650 = Math.max(_0x48fc5d, Math.abs(_0x4be9ef.heights[_0x26602b]) * 0.000001);
      let _0x57c1cc = Math.max(_0x48fc5d, Math.abs(_0x4be9ef.radii[_0x26602b]) * 0.000001);
      if (Math.abs(_0x2f1d83.heights[_0x26602b] - _0x4be9ef.heights[_0x26602b]) > _0x185650 || Math.abs(_0x2f1d83.radii[_0x26602b] - _0x4be9ef.radii[_0x26602b]) > _0x57c1cc) {
        return false;
      }
    }
    return true;
  }
  var _0x394686 = class {
    access;
    pending = null;
    lastRaw = Number.NaN;
    lastTelemetryAt = Number.NEGATIVE_INFINITY;
    actualZoom = Number.NaN;
    actualRaw = Number.NaN;
    active = true;
    constructor(_0xc3308f) {
      this.access = _0xc3308f;
    }
    request(_0x2c8eef) {
      let _0x30a632 = _0x1218d2(_0x2c8eef);
      if (!_0x30a632.ok) {
        return {
          t: "cam_zoom",
          ok: false,
          error: _0x30a632.error,
          req: _0x30a632.req,
          ready: true
        };
      }
      if (!this.active) {
        return {
          t: "cam_zoom",
          ok: false,
          error: "camera zoom lifecycle is stopped",
          req: _0x30a632.req,
          ready: false
        };
      }
      let _0x4593ef = this.access.identity();
      if (_0x4593ef === null) {
        return {
          t: "cam_zoom",
          ok: false,
          error: "no Zoom instance yet",
          req: _0x30a632.req,
          ready: true
        };
      } else {
        this.pending = {
          zoom: _0x30a632.zoom,
          req: _0x30a632.req,
          identity: _0x4593ef
        };
        return null;
      }
    }
    frame(_0x33dbfc) {
      if (!this.active) {
        return [];
      }
      if (this.pending !== null) {
        let _0x189598 = this.pending;
        this.pending = null;
        if (this.access.identity() !== _0x189598.identity) {
          return [this.error("Zoom instance changed before request execution", _0x189598.req)];
        }
        try {
          let _0x1dd4d0 = this.access.read();
          if (_0x1dd4d0 === null) {
            return [this.error("no Zoom instance at request execution", _0x189598.req)];
          }
          let _0xa006da = _0x24dace(_0x1dd4d0);
          if (_0xa006da !== null) {
            return [this.error(_0xa006da, _0x189598.req)];
          }
          let _0x497ee5 = this.access.write(_0x5618c4(_0x189598.zoom));
          if (_0x24dace(_0x497ee5) !== null) {
            return [this.error("camera zoom write returned invalid targets", _0x189598.req)];
          }
          let _0xce0b65 = this.access.read();
          if (_0xce0b65 === null) {
            return [this.error("no Zoom instance after request execution", _0x189598.req)];
          }
          let _0x10426b = _0x24dace(_0xce0b65);
          if (_0x10426b !== null) {
            return [this.error(_0x10426b, _0x189598.req)];
          }
          if (!_0x2a00b0(_0xce0b65, _0x497ee5)) {
            return [this.error("camera zoom readback does not match the native write", _0x189598.req)];
          }
          let _0x2d74fe = this.event(_0xce0b65, _0x189598.req);
          if (_0x2d74fe === null) {
            return [this.error("camera zoom readback is unavailable", _0x189598.req)];
          } else {
            this.lastRaw = _0x2d74fe.raw;
            this.lastTelemetryAt = _0x33dbfc;
            return [_0x2d74fe];
          }
        } catch (_0x3a7ca4) {
          return [this.error(_0x3a7ca4 instanceof Error ? _0x3a7ca4.message : String(_0x3a7ca4), _0x189598.req)];
        }
      }
      let _0x4490ab;
      try {
        _0x4490ab = this.access.read();
      } catch {
        return [];
      }
      if (_0x4490ab === null) {
        return [];
      }
      let _0xb062c6 = _0x4490ab.radii.length < 2 ? Number.NaN : _0x4490ab.radii[1];
      if (!Number.isFinite(_0xb062c6) || Number.isFinite(this.lastRaw) && Math.abs(_0xb062c6 - this.lastRaw) <= _0x48fc5d || _0x33dbfc - this.lastTelemetryAt < _0x14727d) {
        return [];
      }
      let _0x41bbf8 = this.event(_0x4490ab, 0);
      if (_0x41bbf8 === null) {
        return [];
      } else {
        this.lastRaw = _0x41bbf8.raw;
        this.lastTelemetryAt = _0x33dbfc;
        return [_0x41bbf8];
      }
    }
    reset() {
      this.pending = null;
      this.lastRaw = Number.NaN;
      this.lastTelemetryAt = Number.NEGATIVE_INFINITY;
      this.actualZoom = Number.NaN;
      this.actualRaw = Number.NaN;
    }
    actual() {
      if (Number.isFinite(this.actualZoom) && Number.isFinite(this.actualRaw)) {
        return {
          zoom: this.actualZoom,
          raw: this.actualRaw
        };
      } else {
        return null;
      }
    }
    reportNextFrame() {
      this.lastRaw = Number.NaN;
      this.lastTelemetryAt = Number.NEGATIVE_INFINITY;
    }
    suspend() {
      this.active = false;
      this.reset();
    }
    resume() {
      if (!this.active) {
        this.active = true;
        this.reset();
      }
    }
    event(_0xca33b4, _0x50bc59) {
      let _0x2ae0c5 = _0x2ab6f1(_0xca33b4.radii);
      if (_0x2ae0c5 === null) {
        return null;
      } else {
        this.actualZoom = _0x2ae0c5;
        this.actualRaw = _0xca33b4.radii[1];
        return {
          t: "cam_zoom",
          ok: true,
          zoom: _0x2ae0c5,
          raw: this.actualRaw,
          req: _0x50bc59,
          ready: true
        };
      }
    }
    error(_0x2b045b, _0x3fcd2a) {
      return {
        t: "cam_zoom",
        ok: false,
        error: _0x2b045b,
        req: _0x3fcd2a,
        ready: true
      };
    }
  };
  var _0x1a03ce = class {
    pending = null;
    releasing = false;
    request(_0x36f832, _0x4fd6ec, _0xff842e, _0x4534f4) {
      this.pending = _0x36f832;
      if (this.releasing) {
        return;
      }
      let _0x262734 = () => {
        this.releasing = false;
        let _0x2097b7 = this.pending;
        this.pending = null;
        if (_0x2097b7 !== null) {
          _0x4534f4(_0x2097b7);
        }
      };
      if (!_0x4fd6ec()) {
        _0x262734();
        return;
      }
      this.releasing = true;
      _0xff842e(_0x262734);
    }
  };
  var _0x120fe0 = class {
    verifyMs;
    owner = null;
    original = null;
    applied = false;
    error = "";
    lastAttemptAt = Number.NEGATIVE_INFINITY;
    releasing = false;
    constructor(_0x39b135 = 500) {
      this.verifyMs = _0x39b135;
    }
    needsObservation(_0x22c222, _0x5b57f4) {
      return this.owner !== _0x22c222 || _0x5b57f4 - this.lastAttemptAt >= this.verifyMs;
    }
    observe(_0x5ae295, _0x11ff06, _0x32319c) {
      if (this.owner !== _0x5ae295) {
        this.forget();
        this.owner = _0x5ae295;
        this.original = _0x11ff06;
      }
      this.releasing = false;
      if (_0x11ff06) {
        this.applied = false;
        this.lastAttemptAt = _0x32319c;
        return {
          action: "disable",
          enabled: false
        };
      } else {
        this.applied = true;
        this.error = "";
        this.lastAttemptAt = _0x32319c;
        return null;
      }
    }
    confirm(_0x179855, _0x1d811b) {
      this.releasing = false;
      if (_0x179855) {
        this.fail("fog disable readback remained enabled");
        return;
      }
      this.applied = true;
      this.error = "";
      this.lastAttemptAt = _0x1d811b;
    }
    release(_0x1c8f1d, _0x4da253) {
      if (this.owner === null || this.original === null) {
        return null;
      } else if (_0x1c8f1d !== this.owner) {
        this.forget();
        return null;
      } else {
        this.applied = false;
        if (_0x4da253 === this.original) {
          this.forget();
          return null;
        } else {
          this.releasing = true;
          return {
            action: "restore",
            enabled: this.original
          };
        }
      }
    }
    confirmRelease(_0x14208d) {
      if (!!this.releasing && this.original !== null) {
        if (_0x14208d !== this.original) {
          this.fail("fog restore readback did not match the captured value");
          return;
        }
        this.forget();
      }
    }
    fail(_0xf70625) {
      this.applied = false;
      this.error = _0xf70625;
      this.releasing = false;
    }
    forget() {
      this.owner = null;
      this.original = null;
      this.applied = false;
      this.error = "";
      this.lastAttemptAt = Number.NEGATIVE_INFINITY;
      this.releasing = false;
    }
    status() {
      return {
        applied: this.applied,
        error: this.error
      };
    }
    hasOwner() {
      return this.owner !== null && this.original !== null;
    }
  };
  var _0x11ee19 = class {
    access;
    state;
    verifyMs;
    cameraIdentity = null;
    owner = null;
    scene = null;
    lastTransitionAt = Number.NEGATIVE_INFINITY;
    constructor(_0x19f582, _0x11cffb = 500) {
      this.access = _0x19f582;
      this.verifyMs = _0x11cffb;
      this.state = new _0x120fe0(_0x11cffb);
    }
    frame(_0x464efa, _0x37742d) {
      if (_0x464efa !== null) {
        try {
          let _0x36590b = this.access.identity(_0x464efa);
          if (_0x36590b === null) {
            return;
          }
          if (this.owner !== null && _0x36590b.owner !== this.owner) {
            if (_0x36590b.scene === this.scene) {
              if (_0x37742d - this.lastTransitionAt < this.verifyMs) {
                return;
              }
              this.lastTransitionAt = _0x37742d;
              let _0x474e39 = this.state.release(this.owner, this.access.read());
              if (_0x474e39 !== null) {
                this.access.write(_0x474e39.enabled);
                this.state.confirmRelease(this.access.read());
              }
              if (this.state.hasOwner()) {
                return;
              }
            } else {
              this.state.forget();
            }
            this.owner = null;
            this.scene = null;
          }
          this.cameraIdentity = _0x464efa;
          this.owner = _0x36590b.owner;
          this.scene = _0x36590b.scene;
          if (!this.state.needsObservation(_0x36590b.owner, _0x37742d)) {
            return;
          }
          let _0x69f914 = this.state.observe(_0x36590b.owner, this.access.read(), _0x37742d);
          if (_0x69f914 === null) {
            return;
          }
          this.access.write(_0x69f914.enabled);
          this.state.confirm(this.access.read(), _0x37742d);
        } catch (_0x1cb611) {
          this.state.fail(_0x1cb611 instanceof Error ? _0x1cb611.message : String(_0x1cb611));
        }
      }
    }
    release() {
      if (this.cameraIdentity !== null) {
        try {
          let _0x44b463 = this.access.identity(this.cameraIdentity);
          if (_0x44b463 === null) {
            this.forget();
            return;
          }
          let _0x27634b = this.state.release(_0x44b463.owner, this.access.read());
          if (_0x27634b !== null) {
            this.access.write(_0x27634b.enabled);
            this.state.confirmRelease(this.access.read());
          }
          this.cameraIdentity = null;
          this.owner = null;
          this.scene = null;
        } catch (_0x5494f0) {
          this.state.fail(_0x5494f0 instanceof Error ? _0x5494f0.message : String(_0x5494f0));
        }
      }
    }
    forget() {
      this.cameraIdentity = null;
      this.owner = null;
      this.scene = null;
      this.lastTransitionAt = Number.NEGATIVE_INFINITY;
      this.state.forget();
    }
    status() {
      return this.state.status();
    }
    hasOwner() {
      return this.state.hasOwner();
    }
  };
  var _0x46e143 = class {
    current = "";
    get value() {
      return this.current;
    }
    observe(_0x131c73) {
      let _0x3814e3 = typeof _0x131c73 == "string" ? _0x131c73.trim() : "";
      if (_0x3814e3.length > 0) {
        this.current = _0x3814e3;
      }
      return this.current;
    }
    reset() {
      this.current = "";
    }
  };
  function _0x183647(_0x2f5caa, _0x358e9e, _0x375687, _0x151ab3) {
    if (_0x2f5caa[_0x375687] || _0x358e9e[_0x375687] !== undefined) {
      return;
    }
    let _0x5a4eac = _0x151ab3();
    if (_0x5a4eac.trim().length > 0) {
      _0x358e9e[_0x375687] = _0x5a4eac;
    }
  }
  function _0x27ee2b(_0x15e1d1, _0x57a956, _0xd197c7, _0x46044f) {
    if (_0x15e1d1) {
      if (_0x57a956) {
        if (_0xd197c7 && _0x46044f !== 43) {
          return "not-friend-card";
        } else {
          return null;
        }
      } else {
        return "identity-mismatch";
      }
    } else {
      return "slot-gone";
    }
  }
  var _0x23ce22 = class {
    pending = null;
    generation = 0;
    get busy() {
      return this.pending !== null;
    }
    ask(_0x54101c, _0x48614e, _0x1bfb79, _0x3bb1ec, _0x21e326) {
      let _0x13fde5 = _0x54101c === "normal" || _0x54101c === "withneck" || _0x54101c === "auto";
      let _0x199c83 = _0x13fde5 ? _0x54101c : "normal";
      let _0x244db5 = typeof _0x48614e == "number" && Number.isInteger(_0x48614e) && _0x48614e > 0 && _0x48614e <= 4294967295 ? _0x48614e : 0;
      let _0x5bd6e3 = {
        req: _0x244db5,
        mode: _0x199c83,
        generation: 0,
        expiresAt: 0,
        replied: false
      };
      if (!_0x13fde5) {
        return {
          job: _0x5bd6e3,
          error: "invalid mode"
        };
      }
      if (_0x244db5 === 0) {
        return {
          job: _0x5bd6e3,
          error: "invalid request token"
        };
      }
      if (!_0x21e326) {
        return {
          job: _0x5bd6e3,
          error: "rebirth offsets not loaded"
        };
      }
      if (this.pending !== null) {
        return {
          job: _0x5bd6e3,
          error: "busy"
        };
      }
      let _0x493700 = {
        req: _0x244db5,
        mode: _0x199c83,
        generation: ++this.generation,
        expiresAt: _0x1bfb79 + _0x3bb1ec,
        replied: false
      };
      this.pending = _0x493700;
      return {
        job: _0x493700,
        error: null
      };
    }
    expire(_0x536106, _0x5b73d9) {
      if (this.pending === null || this.pending.generation !== _0x536106 || _0x5b73d9 < this.pending.expiresAt) {
        return null;
      }
      let _0x42e8d9 = this.pending;
      this.pending = null;
      return _0x42e8d9;
    }
    take(_0x24e291) {
      if (this.pending === null) {
        return null;
      }
      let _0x3e31c2 = this.pending;
      this.pending = null;
      return {
        job: _0x3e31c2,
        error: _0x24e291 >= _0x3e31c2.expiresAt ? "watchdog expired" : null
      };
    }
    reset() {
      let _0x4e929e = this.pending;
      this.pending = null;
      this.generation++;
      return _0x4e929e;
    }
    complete(_0xcac528) {
      if (_0xcac528.replied) {
        return false;
      } else {
        _0xcac528.replied = true;
        return true;
      }
    }
  };
  function _0x43f6d8(_0x1f9d2d, _0x492e6f) {
    if (_0x1f9d2d) {
      if (_0x492e6f) {
        return null;
      } else {
        return "no zone connection";
      }
    } else {
      return "no server connection yet";
    }
  }
  function _0x1efe5e(_0x4bf2c6, _0x15b713, _0x49fe8c, _0x180aa0) {
    if (_0x4bf2c6) {
      if (_0x15b713) {
        return "tyranny land";
      } else if (_0x49fe8c) {
        return "confronting";
      } else if (_0x180aa0) {
        return "post-confront grace";
      } else {
        return null;
      }
    } else {
      return "player not dead";
    }
  }
  function _0x3fd76e(_0xe18962, _0x783429, _0x3cd34c) {
    if (_0xe18962 === "normal") {
      return {
        ok: true,
        useRosary: false,
        error: ""
      };
    } else if (_0x783429) {
      if (_0xe18962 === "withneck" && !_0x3cd34c) {
        return {
          ok: false,
          useRosary: false,
          error: "no valid rosary"
        };
      } else {
        return {
          ok: true,
          useRosary: _0x3cd34c,
          error: ""
        };
      }
    } else {
      return {
        ok: false,
        useRosary: null,
        error: "equipment unavailable"
      };
    }
  }
  function _0x40e0ce(_0x21e26f, _0xa33b05, _0x5d3067) {
    if (_0x21e26f === "normal" || !_0xa33b05) {
      return _0x3fd76e(_0x21e26f, false, false);
    } else {
      return _0x3fd76e(_0x21e26f, true, _0x5d3067());
    }
  }
  var _0x1ee73 = class {
    loadingValue = null;
    loadingSource = 0;
    loadingStampMs = 0;
    deadValue = null;
    deadStampMs = 0;
    reset() {
      this.loadingValue = null;
      this.loadingSource = 0;
      this.loadingStampMs = 0;
      this.deadValue = null;
      this.deadStampMs = 0;
    }
    beginHookSample(_0x24dcc7) {
      this.loadingValue = null;
      this.loadingSource = 0;
      this.loadingStampMs = _0x24dcc7;
      this.deadValue = null;
      this.deadStampMs = _0x24dcc7;
    }
    observeLoading(_0x1a0512, _0x490852) {
      this.loadingValue = _0x1a0512;
      this.loadingSource = _0x490852;
    }
    observeDead(_0x5e6561) {
      this.deadValue = _0x5e6561;
    }
    loadingAge(_0x3593b6) {
      return this.age(this.loadingStampMs, _0x3593b6);
    }
    deadAge(_0x26288c) {
      return this.age(this.deadStampMs, _0x26288c);
    }
    age(_0x1a91ee, _0x57d474) {
      if (_0x1a91ee === 0) {
        return null;
      } else {
        return Math.max(0, _0x57d474 - _0x1a91ee);
      }
    }
  };
  function _0x16d145(_0x894b84) {
    let _0x216296 = false;
    let _0x2dbac4 = 0;
    for (let _0x3f0a45 = 0; _0x3f0a45 < _0x894b84.length; _0x3f0a45++) {
      try {
        let _0xb1dc1a = _0x894b84[_0x3f0a45]();
        if (_0xb1dc1a === null) {
          continue;
        }
        _0x216296 = true;
        if (_0xb1dc1a) {
          _0x2dbac4 |= 1 << _0x3f0a45;
        }
      } catch {}
    }
    return {
      value: _0x216296 ? _0x2dbac4 !== 0 : null,
      source: _0x2dbac4
    };
  }
  function _0x233988(_0x22af88) {
    return typeof _0x22af88 == "number" && Number.isInteger(_0x22af88) && _0x22af88 >= 0 && _0x22af88 <= 65535;
  }
  function _0x154298(_0x1c4d02, _0x5ee9ae, _0x5439e2, _0x526df9, _0x32dddf) {
    if (_0x1c4d02 === null) {
      return "slot unavailable";
    } else if (_0x1c4d02.amount <= 0) {
      return "slot empty";
    } else if (_0x1c4d02.index !== _0x5ee9ae) {
      return "slot changed";
    } else if (_0x1c4d02.main !== _0x5439e2 || _0x1c4d02.sub !== _0x526df9) {
      return "item changed";
    } else if (_0x1c4d02.type !== _0x32dddf) {
      return "wrong item type";
    } else {
      return null;
    }
  }
  var _0x4abbf9 = class {
    pending = null;
    get busy() {
      return this.pending !== null;
    }
    begin(_0x2b0c10, _0xd1dfb8, _0x5a8f4c, _0x793de6) {
      if (!Number.isInteger(_0xd1dfb8) || _0xd1dfb8 <= 0 || _0xd1dfb8 > 4294967295) {
        return {
          job: null,
          error: "invalid request token"
        };
      }
      if (this.pending !== null) {
        return {
          job: null,
          error: "busy"
        };
      }
      let _0xe63856 = {
        action: _0x2b0c10,
        req: _0xd1dfb8,
        expiresAt: _0x5a8f4c + _0x793de6
      };
      this.pending = _0xe63856;
      return {
        job: _0xe63856,
        error: null
      };
    }
    finish(_0x3bd4ed) {
      let _0x1e05fa = this.pending;
      if (_0x1e05fa === null || (_0x1e05fa.action === "feed" ? "feed" : "summon") !== _0x3bd4ed) {
        return null;
      } else {
        this.pending = null;
        return _0x1e05fa;
      }
    }
    expire(_0x34d255) {
      if (this.pending === null || _0x34d255 < this.pending.expiresAt) {
        return null;
      } else {
        return this.reset();
      }
    }
    reset() {
      let _0x508b16 = this.pending;
      this.pending = null;
      return _0x508b16;
    }
  };
  function _0xfdaaf9(_0xd0d4fc, _0x2e3118, _0x4c472d) {
    if (!Number.isInteger(_0xd0d4fc) || _0xd0d4fc < 0 || _0xd0d4fc > _0x2e3118) {
      throw new Error(_0x4c472d + " is outside its unsigned range");
    }
    return _0xd0d4fc;
  }
  function _0x1b0a84(_0x2a11cc) {
    if (!Number.isInteger(_0x2a11cc) || _0x2a11cc < 0) {
      throw new Error("timestamp is invalid");
    }
    return _0x2a11cc;
  }
  function _0x47dfcc(_0x533c03) {
    return {
      t: "challenge",
      challengeId: _0xfdaaf9(_0x533c03.challengeId, 4294967295, "challengeId"),
      challengeType: _0xfdaaf9(_0x533c03.challengeType, 255, "challengeType"),
      timeoutSec: _0xfdaaf9(_0x533c03.timeoutSec, 255, "timeoutSec"),
      attemptsLeft: _0xfdaaf9(_0x533c03.attemptsLeft, 255, "attemptsLeft"),
      imageLen: _0xfdaaf9(_0x533c03.imageLen, 8192, "imageLen"),
      receivedUnixMs: _0x1b0a84(_0x533c03.receivedUnixMs)
    };
  }
  function _0x876f4a(_0x4157f1, _0x3bc3e6, _0x2ae7f9) {
    if (typeof _0x3bc3e6 != "string") {
      throw new Error("answer is not a string");
    }
    return {
      t: "challenge_submission",
      challengeId: _0xfdaaf9(_0x4157f1, 4294967295, "challengeId"),
      answer: _0x3bc3e6,
      observedUnixMs: _0x1b0a84(_0x2ae7f9)
    };
  }
  function _0x19a4a4(_0x5be69b, _0x340edf, _0x110d89, _0x178d06) {
    return {
      t: "challenge_result",
      challengeId: _0xfdaaf9(_0x5be69b, 4294967295, "challengeId"),
      result: _0xfdaaf9(_0x340edf, 255, "result"),
      attemptsLeft: _0xfdaaf9(_0x110d89, 255, "attemptsLeft"),
      receivedUnixMs: _0x1b0a84(_0x178d06)
    };
  }
  var _0x487fe5 = {
    t0: 0,
    t1: 0,
    t2: 0
  };
  var _0x4b6fde = {
    t0: 0,
    t1: 0,
    t2: 0
  };
  var _0x118409 = {
    t0: false,
    t1: false,
    t2: false
  };
  var _0x2c4af2 = {
    t0: null,
    t1: null,
    t2: null
  };
  var _0x36ddc8 = null;
  var _0x109497 = 0;
  var _0x4c6f1e = {};
  var _0x5c8599 = null;
  var _0x49db6d = false;
  var _0x313980 = 0;
  var _0x35ce2a = new Uint8Array(64);
  var off = null;
  var _0x9ca124 = NULL;
  var _0xdb6669 = 0;
  var _0x3b379a = false;
  var _0x43b4ce = [];
  var _0x46bd97 = "offsets not applied";
  var _0xcd8a73 = [];
  var _0xed018 = null;
  var _0x298ea0 = NULL;
  var _0x390ac2 = NULL;
  var _0x67647e = null;
  var _0x44669c = false;
  var _0x43c9d6 = false;
  var _0x3aa646 = false;
  var _0x569b58 = false;
  var _0x27f61a = [];
  var _0x50cd59 = NULL;
  var _0x369dae = false;
  var _0x8b4a0e = null;
  var _0x33963e = {};
  var _0x42cbb7 = null;
  var _0x18794e = [];
  var _0x46bd9a = "offsets not applied";
  var _0x548284 = null;
  var _0x4856fe = 0;
  var _0x2fabd3 = 1000;
  var _0x3a671a = null;
  var _0x2a51b7 = false;
  var _0x25cf34 = false;
  var _0x35f8bb = [];
  var _0x294766 = "offsets not applied";
  var _0x304e93 = null;
  var _0xcbf549 = null;
  var _0x2779b0 = NULL;
  var _0x3a4dc3 = NULL;
  var _0x481397 = 0;
  var _0x2b50d5 = 0;
  var _0x40063d = NULL;
  var _0x82659a = null;
  var _0x58d068 = null;
  var _0x505f89 = null;
  var _0x8df09b = false;
  var _0x4dcfb5 = [];
  var _0x481f5c = null;
  var _0x5923fc = new _0x1a03ce();
  var _0x120c62 = false;
  var _0x38ac97 = NULL;
  var _0x4af91f = [];
  var _0x5aa6c0 = "offsets not applied";
  var _0x1ca03c = false;
  var _0x16d9be = NULL;
  var _0x561396 = [];
  var _0xcf39b4 = "offsets not applied";
  var _0x5e293d = null;
  var _0x24f684 = 10;
  var _0x3e1997 = -1;
  var _0x448e55 = 10;
  var _0xfeda7a = false;
  var _0x5e47fc = NULL;
  var _0x21193b = [];
  var _0x11dcc0 = "offsets not applied";
  var _0xf43ce = "";
  var _0x1467f2 = null;
  var _0x3bbe00 = NULL;
  var _0x210b66 = false;
  var _0x53c8d0 = NULL;
  var _0x51bb09 = [];
  var _0x511771 = "offsets not applied";
  var _0x5a9ced = null;
  var _0x33d100 = false;
  var _0x2ea383 = [];
  var _0x3821d4 = "offsets not applied";
  var _0x15d7f3 = new _0x1ee73();
  var _0x1a3467 = 10000;
  var _0x3845a7 = false;
  var _0x598183 = [];
  var _0xa669d5 = "offsets not applied";
  var _0x4fbebf = false;
  var _0x392a93 = [];
  var _0x1293d9 = "offsets not applied";
  var _0xab855f = new _0x46e143();
  var _0x176816 = new _0x23ce22();
  var _0x3980f1 = null;
  var _0x526164 = false;
  var _0x26d215 = [];
  var _0x207859 = "offsets not applied";
  var _0x43d22f = 0;
  var _0xaba49a = null;
  var _0x4c024d = false;
  var _0x40d52d = [];
  var _0x37d827 = "offsets not applied";
  var _0x475d3e = 0;
  var _0x3f745b = null;
  var _0x528654 = false;
  var _0x345e5a = [];
  var _0x3924ee = "offsets not applied";
  var _0x27b05c = 0;
  var _0x24fb9b = null;
  var _0x17a10c = false;
  var _0x4901c7 = [];
  var _0x3f3713 = "offsets not applied";
  var _0x44b3ec = NULL;
  var imgFillAmount = -1;
  var _0x5b7018 = 0;
  var _0x5f0b61 = 0;
  var _0x3a3a4d = 0;
  var _0x338380 = 2000;
  var _0x5c897b = 2;
  var _0x923b4d = false;
  var _0x48b995 = [];
  var _0x1704dc = "offsets not applied";
  var _0x2aa668 = "/storage/emulated/0/Android/data/com.klab.klassxonline/files";
  var _0x1a59ec = "hotkey.save";
  var _0x5f4082 = false;
  var _0x455844 = [];
  var _0x18b634 = "offsets not applied";
  var _0x2a2537 = 3;
  var _0x442a67 = 3;
  var _0x2c5b60 = 0;
  var _0x908c94 = 1;
  var _0xec09a8 = 3;
  var _0x3b935a = 5000;
  var _0x393129 = null;
  var _0x545f85 = false;
  var _0x18c945 = [];
  var _0x5590df = "offsets not applied";
  var _0xa75ccc = 0;
  var KEYS_PET = ["rvaPickAnchor", "rvaPetGiveFood", "rvaPetSummon", "rvaPetDismiss", "rvaPetGiveFoodResponse", "rvaPetSummonResponse", "scmPetFullness", "phActivePetCardSlot", "phPetGlobalId", "phPetObject", "petFoodResult", "petFoodNewFullness", "petFoodConsumedSlot", "petSummonResult", "petSummonGlobalId", "petSummonCardSlot"];
  var _0x120702 = false;
  var _0x335116 = [];
  var _0x38c3ed = "offsets not applied";
  var _0x22271f = null;
  var _0x1078f7 = null;
  var _0x20ad38 = null;
  var _0x533468 = null;
  var _0x5e6944 = null;
  var _0x109505 = new _0x4abbf9();
  var _0x442f8f = 10000;
  var _0xf15267 = null;
  var _0x2d34ea = 12;
  var _0x4f77d0 = 4;
  var _0x140423 = 10;
  var _0x2fe159 = 6;
  var _0x1a194d = 0;
  var _0x2508e4 = [];
  var _0x8ea0f0 = [];
  var _0x54bde4 = [];
  var _0x74250c = "offsets not applied";
  var _0x5a5014 = new Map();
  var _0x4467b3 = null;
  var _0x23b312 = null;
  var _0x3565c8 = null;
  var _0x214aab = null;
  var _0x4d38be = null;
  var _0x80b027 = null;
  var _0x4d4f06 = null;
  var _0x2e9b66 = null;
  var _0xc5f073 = null;
  var _0xc1f0b3 = null;
  var _0x435a49 = null;
  var _0x50e651 = NULL;
  var _0x2612f8 = "/data/local/tmp/capy-zone-trace.log";
  var _0x2c023b = null;
  var _0x49f464 = "not initialised";
  function _0x1296cb(_0x4007a3) {
    if (!_0x4007a3) {
      _0x49f464 = "off";
      return;
    }
    try {
      _0x2c023b = new File(_0x2612f8, "w");
      _0x49f464 = "file";
    } catch (_0x2d58ed) {
      _0x2c023b = null;
      _0x49f464 = "file failed: " + _0x2d58ed;
    }
    try {
      let _0x4df917 = NULL;
      let _0x2518b9 = Process.findModuleByName("liblog.so");
      if (_0x2518b9 !== null) {
        try {
          _0x4df917 = _0x2518b9.findExportByName("__android_log_write") || NULL;
        } catch {
          _0x4df917 = NULL;
        }
      }
      if (_0x4df917.isNull()) {
        try {
          _0x4df917 = Module.findExportByName("liblog.so", "__android_log_write") || NULL;
        } catch {
          _0x4df917 = NULL;
        }
      }
      if (_0x4df917.isNull()) {
        _0x49f464 += ", liblog export not found";
      } else {
        _0x435a49 = new NativeFunction(_0x4df917, "int", ["int", "pointer", "pointer"]);
        _0x50e651 = Memory.allocUtf8String("CapyAgent");
        _0x49f464 += "+logcat";
      }
    } catch {
      _0x435a49 = null;
      _0x49f464 += ", liblog threw";
    }
    _0x13ee08("--- agent trace open ---");
  }
  function _0x13ee08(_0x129ae0) {
    if (_0x2c023b !== null) {
      try {
        _0x2c023b.write(_0x129ae0 + "\n");
        _0x2c023b.flush();
      } catch {}
    }
    if (_0x435a49 !== null) {
      try {
        _0x435a49(4, _0x50e651, Memory.allocUtf8String(_0x129ae0));
      } catch {}
    }
  }
  var _0x32ddda = null;
  var _0x9c1407 = null;
  var _0x50671e = null;
  var _0x3f4ff3 = null;
  var _0x2522df = null;
  var _0x1cf549 = null;
  var _0x39ae42 = null;
  var _0x68f14c = null;
  var _0x3ecfea = null;
  var _0x1c5718 = null;
  var _0x20c223 = null;
  var _0x416720 = null;
  var _0x484914 = null;
  var _0x5212d5 = null;
  var _0x5d8775 = null;
  var _0x47e27b = null;
  var _0x3cce3b = null;
  var _0x1ee86b = null;
  var _0x1975a5 = null;
  var _0x334efa = null;
  var _0x43e1e6 = null;
  var _0x351656 = null;
  var _0xafd509 = null;
  var _0x256353 = null;
  var _0xc2356e = null;
  var _0x3493d7 = null;
  var _0x8b33cc = null;
  var _0x5a3803 = null;
  var _0xdefa3c = null;
  var _0x53e867 = null;
  var _0x3b52d3 = null;
  var _0x1e0539 = null;
  var _0x3be0a9 = null;
  var _0x441c68 = null;
  var _0x52cd94 = null;
  var _0x27c34b = null;
  var _0x2dbd2e = null;
  var _0x41bf4e = null;
  var _0x4f68f0 = null;
  var _0x148505 = null;
  var _0x552ea7 = null;
  var _0x171e7b = null;
  var _0x4b666c = null;
  var _0x394502 = null;
  var _0x4ce11e = null;
  var _0x590e9e = null;
  var _0x5a95f5 = null;
  var _0x4be5bd = null;
  var _0x242066 = null;
  var _0x402cd6 = null;
  var _0x449d2d = null;
  var _0x5788d6 = NULL;
  var _0x5749bd = NULL;
  var _0x3f6352 = NULL;
  var _0x548f62 = false;
  var _0x3cb965 = NULL;
  var _0xbfec86 = NULL;
  var _0x95429a = 0;
  var _0xb637ed = 0;
  function _0x42437c(_0x3cbe34) {
    let _0x1ae942 = [];
    if (_0x3cbe34.isNull()) {
      return _0x1ae942;
    }
    let off = off;
    let arrCount = _0x3cbe34.add(off.arrCount).readU32();
    if (arrCount === 0 || arrCount > 1048576) {
      return _0x1ae942;
    }
    let arrFirst = _0x3cbe34.add(off.arrFirst).readByteArray(arrCount * off.arrStride);
    if (arrFirst == null) {
      return _0x1ae942;
    }
    let _0x28bb3d = new DataView(arrFirst);
    for (let _0x428b38 = 0; _0x428b38 < arrCount; _0x428b38++) {
      let _0xe10cd3 = _0x28bb3d.getUint32(_0x428b38 * off.arrStride, true);
      let _0x1384de = _0x28bb3d.getUint32(_0x428b38 * off.arrStride + 4, true);
      if (_0xe10cd3 !== 0 || _0x1384de !== 0) {
        _0x1ae942.push(ptr(_0xe10cd3 + _0x1384de * 4294967296));
      }
    }
    return _0x1ae942;
  }
  function _0x2df1c6(_0x3628b1, _0x5f4bad) {
    let off = off;
    let _0x570318 = _0x3628b1.add(_0x5f4bad).readPointer();
    if (_0x570318.isNull()) {
      return "";
    }
    let strLen = _0x570318.add(off.strLen).readS32();
    if (strLen <= 0 || strLen > 4096) {
      return "";
    } else {
      return _0x570318.add(off.strChars).readUtf16String(strLen) ?? "";
    }
  }
  function _0x4c8df9(_0x1119b1, _0x1573bc, _0x1a26c2, _0x4da0c3, _0x605572, _0x46b8b2, _0x376d84, _0x30a545, _0x242e5f, _0x5a7139, _0x58136b, _0x4eb33e, _0x81dd57, _0x15d86c, _0x44b887, _0x450198) {
    _0x1119b1.setUint8(_0x1573bc, _0x1a26c2 & 255);
    _0x1119b1.setUint8(_0x1573bc + 1, _0x4da0c3 & 255);
    _0x1119b1.setUint16(_0x1573bc + 2, _0x605572 & 65535, true);
    _0x1119b1.setUint16(_0x1573bc + 4, _0x46b8b2 & 65535, true);
    _0x1119b1.setUint16(_0x1573bc + 6, _0x376d84 & 65535, true);
    _0x1119b1.setUint16(_0x1573bc + 8, _0x30a545 & 65535, true);
    _0x1119b1.setUint16(_0x1573bc + 10, _0x242e5f & 65535, true);
    _0x1119b1.setUint32(_0x1573bc + 12, _0x5a7139 >>> 0, true);
    _0x1119b1.setFloat32(_0x1573bc + 16, _0x58136b, true);
    _0x1119b1.setFloat32(_0x1573bc + 20, _0x4eb33e, true);
    _0x1119b1.setFloat32(_0x1573bc + 24, _0x81dd57, true);
    _0x1119b1.setUint16(_0x1573bc + 28, _0x15d86c & 65535, true);
    _0x1119b1.setUint8(_0x1573bc + 30, _0x44b887 & 255);
    _0x1119b1.setUint8(_0x1573bc + 31, _0x450198 & 255);
  }
  var _0x31b02d = {};
  var _0x3ec545 = {};
  var _0x4d1e66 = {};
  function _0x1c34ac(_0xd8de3d) {
    let off = off;
    let _0x1b9500 = [];
    if (_0xd8de3d.isNull() || off.sfStride <= 0) {
      return _0x1b9500;
    }
    let arrCount = _0xd8de3d.add(off.arrCount).readU32();
    if (arrCount === 0 || arrCount > 512) {
      return _0x1b9500;
    }
    for (let _0x51b782 = 0; _0x51b782 < arrCount; _0x51b782++) {
      let _0x3c3eb0 = _0xd8de3d.add(off.arrFirst + _0x51b782 * off.sfStride);
      let sfNativeId = _0x3c3eb0.add(off.sfNativeId).readU16();
      let sfNativeId_2 = _0x3c3eb0.add(off.sfNativeId + 2).readU16();
      if ((sfNativeId !== 65535 || sfNativeId_2 !== 65535) && (sfNativeId !== 0 || sfNativeId_2 !== 0)) {
        _0x1b9500.push({
          id: sfNativeId + ":" + sfNativeId_2,
          lv: _0x3c3eb0.add(off.sfLevel).readU16(),
          age: _0x3c3eb0.add(off.sfAge).readFloat()
        });
      }
    }
    return _0x1b9500;
  }
  function _0x4858e7() {
    let off = off;
    if (off == null || _0x390ac2.isNull()) {
      return [];
    }
    let pcCharLogicPtr = _0x390ac2.add(off.pcCharLogic).readPointer();
    if (pcCharLogicPtr.isNull()) {
      return [];
    } else {
      return _0x1c34ac(pcCharLogicPtr.add(off.clSkillFact).readPointer()).concat(_0x1c34ac(pcCharLogicPtr.add(off.clSystemBuff).readPointer()));
    }
  }
  var _0x87a098 = 65535;
  function _0x472a73(_0x29a5e5, _0x2c7a8c, _0x3fc52c) {
    let off = off;
    if (_0x29a5e5.isNull() || off.sfStride <= 0) {
      return;
    }
    let arrCount = _0x29a5e5.add(off.arrCount).readU32();
    if (arrCount !== 0 && !(arrCount > 512)) {
      for (let _0x68799 = 0; _0x68799 < arrCount; _0x68799++) {
        let _0xb69456 = _0x29a5e5.add(off.arrFirst + _0x68799 * off.sfStride);
        let sfNativeId = _0xb69456.add(off.sfNativeId).readU16();
        let sfNativeId_2 = _0xb69456.add(off.sfNativeId + 2).readU16();
        if (sfNativeId === _0x87a098 || sfNativeId_2 === _0x87a098 || sfNativeId === 0 && sfNativeId_2 === 0) {
          continue;
        }
        let sfAge = 0;
        if (_0x2c7a8c !== "s" || !(sfAge = _0xb69456.add(off.sfAge).readFloat(), sfAge <= 0)) {
          _0x3fc52c.push({
            src: _0x2c7a8c,
            slot: _0x68799,
            main: sfNativeId,
            sub: sfNativeId_2,
            lv: _0xb69456.add(off.sfLevel).readU16(),
            left: sfAge
          });
        }
      }
    }
  }
  function _0x4e7afc() {
    let _0x2d56cb = [];
    let off = off;
    if (off == null || _0x390ac2.isNull()) {
      return _0x2d56cb;
    }
    let pcCharLogicPtr = _0x390ac2.add(off.pcCharLogic).readPointer();
    if (!pcCharLogicPtr.isNull()) {
      _0x472a73(pcCharLogicPtr.add(off.clSkillFact).readPointer(), "s", _0x2d56cb);
      _0x472a73(pcCharLogicPtr.add(off.clSystemBuff).readPointer(), "y", _0x2d56cb);
    }
    return _0x2d56cb;
  }
  function _0xfcabb1(_0x495324) {
    return _0x59f501(_0x495324) || [];
  }
  function _0x59f501(_0x2ebdd0) {
    let off = off;
    if (off == null || _0x298ea0.isNull()) {
      return null;
    }
    let phPlayersPtr = _0x298ea0.add(off.phPlayers).readPointer();
    if (phPlayersPtr.isNull() || _0x2ebdd0 >= phPlayersPtr.add(off.arrCount).readU32()) {
      return null;
    }
    let _0x554e1d = phPlayersPtr.add(off.arrFirst + _0x2ebdd0 * off.arrStride).readPointer();
    if (_0x554e1d.isNull()) {
      return null;
    }
    let unitClientPtr = _0x554e1d.add(off.unitClient).readPointer();
    if (unitClientPtr.isNull()) {
      return null;
    }
    let ccSkillFactsPtr = unitClientPtr.add(off.ccSkillFacts).readPointer();
    if (ccSkillFactsPtr.isNull()) {
      return null;
    } else {
      return _0x1c34ac(ccSkillFactsPtr);
    }
  }
  function _0x9a7c5f(_0x197ad5, _0x3fff0a, _0x21b604 = _0x67647e, _0x4e1ee3 = null) {
    let off = off;
    if (off == null) {
      send({
        t: "census_raw",
        tag: _0x197ad5,
        error: "no offsets",
        login_id: _0xedbb7e(),
        pet: _0x2a8986(),
        loading: _0x15d7f3.loadingValue,
        loading_source: _0x15d7f3.loadingSource,
        loading_age_ms: _0x15d7f3.loadingAge(Date.now()),
        dead: _0x15d7f3.deadValue,
        dead_age_ms: _0x15d7f3.deadAge(Date.now())
      });
      return 0;
    }
    if (_0x298ea0.isNull()) {
      send({
        t: "census_raw",
        tag: _0x197ad5,
        error: "no handler yet",
        login_id: _0xedbb7e(),
        pet: _0x2a8986(),
        loading: _0x15d7f3.loadingValue,
        loading_source: _0x15d7f3.loadingSource,
        loading_age_ms: _0x15d7f3.loadingAge(Date.now()),
        dead: _0x15d7f3.deadValue,
        dead_age_ms: _0x15d7f3.deadAge(Date.now())
      });
      return 0;
    }
    let _0x3a3bd4 = Date.now();
    let _0x5528e6 = _0x298ea0;
    let _0x443d4b = new ArrayBuffer(131072);
    let _0x14d5ae = new DataView(_0x443d4b);
    let _0x5cc447 = 0;
    let _0x2f49b5 = {};
    let _0x4f3ae7 = {};
    let _0x4c7973 = {};
    let _0x19408b = {};
    let _0x4c25a7 = {};
    let _0x5d1873 = _0x3fff0a ? [] : _0x4e7afc();
    let _0x536b12 = _0x42437c(_0x5528e6.add(off.phCrows).readPointer());
    for (let _0xc5a13e = 0; _0xc5a13e < _0x536b12.length && _0x5cc447 < _0x443d4b.byteLength - 32; _0xc5a13e++) {
      let _0x57c1cd = _0x536b12[_0xc5a13e];
      let crowControllerPtr = _0x57c1cd.add(off.crowController).readPointer();
      if (crowControllerPtr.isNull()) {
        continue;
      }
      let aiActorPtr = crowControllerPtr.add(off.aiActor).readPointer();
      if (aiActorPtr.isNull()) {
        continue;
      }
      let gaPositionAddr = aiActorPtr.add(off.gaPosition);
      let aiIsDead = crowControllerPtr.add(off.aiIsDead).readU8();
      let crowNowHp = 0;
      let aiCrowLogicPtr = crowControllerPtr.add(off.aiCrowLogic).readPointer();
      if (!aiCrowLogicPtr.isNull()) {
        crowNowHp = aiCrowLogicPtr.add(off.crowNowHp).readU32();
      }
      let defLevel = 0;
      let defBoss = 0;
      let defType = 2;
      let defHp = 0;
      let crowDataId = _0x57c1cd.add(off.crowDataId).readU16();
      let crowDataId_2 = _0x57c1cd.add(off.crowDataId + 2).readU16();
      let aiMobNpcPtr = crowControllerPtr.add(off.aiMobNpc).readPointer();
      if (!aiMobNpcPtr.isNull()) {
        defLevel = aiMobNpcPtr.add(off.defLevel).readU8();
        defBoss = aiMobNpcPtr.add(off.defBoss).readU8();
        defType = aiMobNpcPtr.add(off.defType).readU8();
        defHp = aiMobNpcPtr.add(off.defHp).readU32();
        let defDataPtr = aiMobNpcPtr.add(off.defData).readPointer();
        if (!defDataPtr.isNull()) {
          let mobMain = defDataPtr.add(off.mobMain).readU16();
          let mobSub = defDataPtr.add(off.mobSub).readU16();
          if (mobMain !== 0 || mobSub !== 0) {
            crowDataId = mobMain;
            crowDataId_2 = mobSub;
          }
        }
      }
      _0x4c8df9(_0x14d5ae, _0x5cc447, defType, (aiIsDead ? 1 : 0) | (defBoss ? 2 : 0), crowDataId, crowDataId_2, crowNowHp, defHp, defLevel, _0x57c1cd.add(off.crowId).readU16(), gaPositionAddr.readFloat(), gaPositionAddr.add(4).readFloat(), gaPositionAddr.add(8).readFloat(), 0, 0, 0);
      // mob HP เป็น u32 ในเกม: now → byte 6–9, max → byte 28–31 (เดิมถูกตัดเหลือ u16)
      _0x14d5ae.setUint32(_0x5cc447 + 6, crowNowHp >>> 0, true);
      _0x14d5ae.setUint32(_0x5cc447 + 28, defHp >>> 0, true);
      _0x5cc447 += 32;
      let _0x4632df = crowDataId + ":" + crowDataId_2;
      if (!_0x31b02d[_0x4632df] && !aiMobNpcPtr.isNull()) {
        _0x31b02d[_0x4632df] = true;
        _0x2f49b5[_0x4632df] = _0x2df1c6(aiMobNpcPtr, off.defName);
      }
    }
    let _0x61d379 = _0x42437c(_0x5528e6.add(off.phPlayers).readPointer());
    let _0x1f1a07 = _0x21b604 === null ? null : _0x21b604.slice();
    for (let _0x20170c = 0; _0x20170c < _0x61d379.length && _0x5cc447 < _0x443d4b.byteLength - 32; _0x20170c++) {
      let _0x43f0a9 = _0x61d379[_0x20170c];
      let _0x3d9299 = 0;
      let _0x5d359e = 0;
      let _0x11a0f8 = 0;
      let sdHp = 0;
      let sdHp_2 = 0;
      let sdLevel = 0;
      let unitClientPtr = _0x43f0a9.add(off.unitClient).readPointer();
      if (!unitClientPtr.isNull()) {
        let ccActorPtr = unitClientPtr.add(off.ccActor).readPointer();
        if (!ccActorPtr.isNull()) {
          let gaPositionAddr = ccActorPtr.add(off.gaPosition);
          _0x3d9299 = gaPositionAddr.readFloat();
          _0x5d359e = gaPositionAddr.add(4).readFloat();
          _0x11a0f8 = gaPositionAddr.add(8).readFloat();
        }
        let ccCharDataPtr = unitClientPtr.add(off.ccCharData).readPointer();
        if (!ccCharDataPtr.isNull()) {
          sdHp = ccCharDataPtr.add(off.sdHp).readU16();
          sdHp_2 = ccCharDataPtr.add(off.sdHp + 2).readU16();
          sdLevel = ccCharDataPtr.add(off.sdLevel).readU16();
        }
      }
      let _0x11e669 = _0x43f0a9.add(off.unitIsSelf).readU8() !== 0;
      if (_0x11e669 && _0x3d9299 === 0 && _0x5d359e === 0 && _0x11a0f8 === 0 && !_0x390ac2.isNull()) {
        let pcActorMovePtr = _0x390ac2.add(off.pcActorMove).readPointer();
        if (!pcActorMovePtr.isNull()) {
          let gaPositionAddr = pcActorMovePtr.add(off.gaPosition);
          _0x3d9299 = gaPositionAddr.readFloat();
          _0x5d359e = gaPositionAddr.add(4).readFloat();
          _0x11a0f8 = gaPositionAddr.add(8).readFloat();
        }
      }
      let unitGaeaId = _0x43f0a9.add(off.unitGaeaId).readU16();
      if (!_0x4d1e66[unitGaeaId]) {
        let _0x5c7fef = _0x2df1c6(_0x43f0a9, off.unitName);
        if (_0x5c7fef.length > 0) {
          _0x4d1e66[unitGaeaId] = true;
          _0x4c7973[unitGaeaId] = _0x5c7fef;
        }
      }
      let _0x26ebe9 = _0x43f0a9.add(off.unitParty).readU32() & 65535;
      if (_0x1f1a07 !== null && _0x1f1a07.indexOf(unitGaeaId) >= 0 && (_0x4e1ee3 === null || _0x4e1ee3.indexOf(unitGaeaId) >= 0)) {
        let _0xf99c1 = _0x11e669 ? _0x5d1873.filter(_0x3cdf84 => _0x3cdf84.src === "s").map(_0x138a6e => ({
          id: _0x138a6e.main + ":" + _0x138a6e.sub,
          lv: _0x138a6e.lv,
          age: _0x138a6e.left
        })) : _0x59f501(unitGaeaId);
        if (_0xf99c1 !== null) {
          _0x19408b[unitGaeaId] = _0xf99c1;
        }
        let _0x35e380 = _0x11e669 && !_0x390ac2.isNull() ? _0x390ac2.add(off.pcTarget) : unitClientPtr.isNull() ? NULL : unitClientPtr.add(off.ccTarget);
        if (!_0x35e380.isNull()) {
          let targetId = _0x35e380.add(off.targetId).readU16();
          _0x4c25a7[unitGaeaId] = {
            t: _0x35e380.add(off.targetCrowType).readU8(),
            id: targetId
          };
        }
      }
      let _0x4c0fea = _0x43f0a9.add(off.unitSchool).readU16() & 255;
      let _0x32ebfe = _0x43f0a9.add(off.unitClass).readU16() & 255;
      let _0x3783c7 = _0x43f0a9.add(off.unitMaster).readU8() !== 0 ? 8 : 0;
      _0x4c8df9(_0x14d5ae, _0x5cc447, 100, (_0x11e669 ? 4 : 0) | _0x3783c7, 0, 0, sdHp, sdHp_2, sdLevel, unitGaeaId, _0x3d9299, _0x5d359e, _0x11a0f8, _0x26ebe9, _0x4c0fea, _0x32ebfe);
      _0x5cc447 += 32;
    }
    let _0x2cc20e = _0x42437c(_0x5528e6.add(off.phItems).readPointer());
    for (let _0x4b0ad4 = 0; _0x4b0ad4 < _0x2cc20e.length && _0x5cc447 < _0x443d4b.byteLength - 32; _0x4b0ad4++) {
      let itemDataPtr = _0x2cc20e[_0x4b0ad4].add(off.itemData).readPointer();
      if (itemDataPtr.isNull()) {
        continue;
      }
      let dropPosAddr = itemDataPtr.add(off.dropPos);
      let sitemNativeId = 0;
      let sitemNativeId_2 = 0;
      let sitemTurn = 0;
      let dropInfoPtr = itemDataPtr.add(off.dropInfo).readPointer();
      if (!dropInfoPtr.isNull()) {
        sitemNativeId = dropInfoPtr.add(off.sitemNativeId).readU16();
        sitemNativeId_2 = dropInfoPtr.add(off.sitemNativeId + 2).readU16();
        sitemTurn = dropInfoPtr.add(off.sitemTurn).readU16();
      }
      let itemItemPtr = _0x2cc20e[_0x4b0ad4].add(off.itemItem).readPointer();
      let itemObjType = 0;
      let itemQuestionType = 0;
      if (!itemItemPtr.isNull()) {
        itemObjType = itemItemPtr.add(off.itemObjType).readU8();
        let itemObjQuestionPtr = itemItemPtr.add(off.itemObjQuestion).readPointer();
        if (!itemObjQuestionPtr.isNull()) {
          itemQuestionType = itemObjQuestionPtr.add(off.itemQuestionType).readU8();
        }
        let _0x4da38b = sitemNativeId + ":" + sitemNativeId_2;
        _0x183647(_0x3ec545, _0x4f3ae7, _0x4da38b, () => _0x2df1c6(itemItemPtr, off.itemObjName));
        if (_0x4f3ae7[_0x4da38b] !== undefined) {
          _0x3ec545[_0x4da38b] = true;
        }
      }
      _0x4c8df9(_0x14d5ae, _0x5cc447, 101, 0, sitemNativeId, sitemNativeId_2, sitemTurn, 0, 0, itemDataPtr.add(off.dropId).readU16(), dropPosAddr.readFloat(), dropPosAddr.add(4).readFloat(), dropPosAddr.add(8).readFloat(), 0, itemObjType, itemQuestionType);
      _0x5cc447 += 32;
    }
    let _0x4dbdb2 = _0x42437c(_0x5528e6.add(off.phMoney).readPointer());
    for (let _0x4ee85e = 0; _0x4ee85e < _0x4dbdb2.length && _0x5cc447 < _0x443d4b.byteLength - 32; _0x4ee85e++) {
      let goldDataPtr = _0x4dbdb2[_0x4ee85e].add(off.goldData).readPointer();
      if (goldDataPtr.isNull()) {
        continue;
      }
      let moneyPosAddr = goldDataPtr.add(off.moneyPos);
      _0x4c8df9(_0x14d5ae, _0x5cc447, 102, 0, 0, 0, goldDataPtr.add(off.moneyAmount).readU32(), 0, 0, goldDataPtr.add(off.moneyId).readU16(), moneyPosAddr.readFloat(), moneyPosAddr.add(4).readFloat(), moneyPosAddr.add(8).readFloat(), 0, 0, 0);
      _0x5cc447 += 32;
    }
    let _0x1968fa = Date.now() - _0x3a3bd4;
    if (!_0x3fff0a) {
      _0x487fe5.t2++;
      send({
        t: "census_raw",
        tag: _0x197ad5,
        seq: _0x487fe5.t2,
        rows: _0x5cc447 / 32,
        pass_ms: _0x1968fa,
        login_id: _0xedbb7e(),
        mnames: _0x2f49b5,
        inames: _0x4f3ae7,
        pnames: _0x4c7973,
        buffs: _0x5d1873,
        pbuffs: _0x19408b,
        ptargets: _0x4c25a7,
        partyIds: _0x1f1a07,
        partyPresentIds: _0x4e1ee3,
        qbox: _0x3ed60a(),
        pet: _0x2a8986(),
        loading: _0x15d7f3.loadingValue,
        loading_source: _0x15d7f3.loadingSource,
        loading_age_ms: _0x15d7f3.loadingAge(Date.now()),
        dead: _0x15d7f3.deadValue,
        dead_age_ms: _0x15d7f3.deadAge(Date.now())
      }, _0x443d4b.slice(0, _0x5cc447));
    }
    return _0x1968fa;
  }
  function _0x467650(_0x2c2481) {
    let _0x975fa6 = false;
    let _0x378cfc = setTimeout(() => {
      if (!_0x975fa6) {
        _0x975fa6 = true;
        _0x67647e = null;
        _0x9a7c5f(_0x2c2481, false, null);
      }
    }, 250);
    if (!_0x5b8db7(() => {
      if (_0x975fa6) {
        return;
      }
      let _0x33edea = _0x3adf33();
      let _0x431c27 = _0xb1069e(_0x33edea);
      _0x975fa6 = true;
      clearTimeout(_0x378cfc);
      setImmediate(() => _0x9a7c5f(_0x2c2481, false, _0x33edea, _0x431c27));
    })) {
      clearTimeout(_0x378cfc);
      _0x975fa6 = true;
      _0x67647e = null;
      _0x9a7c5f(_0x2c2481, false, null);
    }
  }
  function _0x17c656() {
    let off = off;
    if (off == null || _0x390ac2.isNull()) {
      return null;
    }
    let _0x3a9e54 = _0x390ac2;
    let pcActorMovePtr = _0x3a9e54.add(off.pcActorMove).readPointer();
    if (pcActorMovePtr.isNull()) {
      return null;
    }
    let _0x503e14 = new ArrayBuffer(80);
    let _0x15ebad = new DataView(_0x503e14);
    let _0x43dfad = Date.now();
    _0x15ebad.setUint32(0, Math.floor(_0x43dfad / 4294967296), true);
    _0x15ebad.setUint32(4, _0x43dfad >>> 0, true);
    let gaPositionAddr = pcActorMovePtr.add(off.gaPosition);
    let gaVelocityAddr = pcActorMovePtr.add(off.gaVelocity);
    let pcManualTargetAddr = _0x3a9e54.add(off.pcManualTarget);
    _0x15ebad.setFloat32(8, gaPositionAddr.readFloat(), true);
    _0x15ebad.setFloat32(12, gaPositionAddr.add(4).readFloat(), true);
    _0x15ebad.setFloat32(16, gaPositionAddr.add(8).readFloat(), true);
    _0x15ebad.setFloat32(20, gaVelocityAddr.readFloat(), true);
    _0x15ebad.setFloat32(24, gaVelocityAddr.add(4).readFloat(), true);
    _0x15ebad.setFloat32(28, gaVelocityAddr.add(8).readFloat(), true);
    _0x15ebad.setFloat32(32, pcManualTargetAddr.readFloat(), true);
    _0x15ebad.setFloat32(36, pcManualTargetAddr.add(4).readFloat(), true);
    _0x15ebad.setFloat32(40, pcManualTargetAddr.add(8).readFloat(), true);
    _0x15ebad.setFloat32(44, pcActorMovePtr.add(off.gaMaxSpeed).readFloat(), true);
    _0x15ebad.setInt32(48, pcActorMovePtr.add(off.gaCorner).readS32(), true);
    _0x15ebad.setUint32(52, _0x3a9e54.add(off.pcActState).readU32(), true);
    _0x15ebad.setUint8(56, _0x3a9e54.add(off.pcAction).readU8());
    _0x15ebad.setUint8(57, _0x3a9e54.add(off.pcManualActive).readU8());
    _0x15ebad.setUint8(58, _0x3a9e54.add(off.pcJoystick).readU8());
    _0x15ebad.setUint8(59, pcActorMovePtr.add(off.gaPathActive).readU8());
    _0x15ebad.setUint8(60, pcActorMovePtr.add(off.gaHasDirect).readU8());
    let pcCharLogicPtr = _0x3a9e54.add(off.pcCharLogic).readPointer();
    if (!pcCharLogicPtr.isNull()) {
      let _0x90976c = (_0x4226b4, _0x582f23) => {
        _0x15ebad.setUint16(_0x582f23, pcCharLogicPtr.add(_0x4226b4).readU16(), true);
        _0x15ebad.setUint16(_0x582f23 + 2, pcCharLogicPtr.add(_0x4226b4 + 2).readU16(), true);
      };
      _0x90976c(off.clHp, 64);
      _0x90976c(off.clMp, 68);
      _0x90976c(off.clSp, 72);
      _0x15ebad.setUint16(76, pcCharLogicPtr.add(off.clLevel).readU16(), true);
      _0x15ebad.setUint8(61, pcCharLogicPtr.add(off.clQItemFact).readU8());
    }
    return _0x503e14;
  }
  var _0x578e43 = [];
  var _0x26800d = false;
  var _0x14e42c = 0;
  var _0x57ca44 = 0;
  var _0x5dc799 = 0;
  var _0x17a426 = 8;
  var _0xe7f9ee = 4;
  var _0x43ff31 = [];
  var _0x52d1d0 = false;
  function _0x18c09a() {
    if (_0x578e43.length === 0 || _0x26800d) {
      return;
    }
    _0x26800d = true;
    let _0x2b23fd = Date.now();
    try {
      let _0x25ba3c = 0;
      while (_0x578e43.length > 0 && _0x25ba3c < _0xe7f9ee) {
        let _0x5b06d2 = _0x578e43.shift();
        try {
          _0x5b06d2();
          _0x14e42c++;
        } catch (_0x5b4ace) {
          _0x57ca44++;
          send({
            t: "frame_job_error",
            error: "" + _0x5b4ace
          });
        }
        _0x25ba3c++;
        if (Date.now() - _0x2b23fd >= _0x17a426) {
          break;
        }
      }
    } finally {
      _0x26800d = false;
    }
  }
  function _0x5cd659() {
    _0x10aaed("frame hooks detached");
    _0x52d1d0 = false;
    for (let _0x3aadfa of _0x43ff31) {
      try {
        _0x3aadfa.detach();
      } catch {}
    }
    _0x43ff31.length = 0;
    _0x578e43.length = 0;
    _0x393129 = null;
    _0x298ea0 = NULL;
    _0x390ac2 = NULL;
    let _0x191524 = _0x176816.reset();
    if (_0x191524 !== null) {
      _0x180e35(_0x191524, false, null, "handler hook detached");
    }
    if (_0x3980f1 !== null) {
      clearTimeout(_0x3980f1);
      _0x3980f1 = null;
    }
    _0x36d806("handler hook detached");
  }
  function _0x19bad9() {
    _0x5cd659();
    let off = off;
    let _0x2324c0 = _0x3166d6(off.rvaHandlerUpdate, "PlayerHandler.Update");
    if (typeof _0x2324c0 == "string") {
      return _0x2324c0;
    }
    let _0x58aa73 = _0x3166d6(off.rvaFrameMove, "PlayerController.FrameMove");
    if (typeof _0x58aa73 == "string") {
      return _0x58aa73;
    } else {
      _0x43ff31.push(Interceptor.attach(_0x2324c0, {
        onEnter(args) {
          _0x298ea0 = args[0];
          _0x5a73cb();
          _0x394146();
        }
      }));
      _0x43ff31.push(Interceptor.attach(_0x58aa73, {
        onEnter(args) {
          _0x390ac2 = args[0];
          _0x5dc799++;
          _0x18c09a();
          _0xfaff3b();
        },
        onLeave() {
          _0x5d5934();
        }
      }));
      _0x52d1d0 = true;
      return null;
    }
  }
  function _0x3166d6(_0x5ea7e2, _0x5af6cc) {
    if (_0x5ea7e2 <= 0 || _0x5ea7e2 >= _0xdb6669) {
      return _0x5af6cc + ": the address is outside the module";
    }
    let _0x5ea63c = _0x9ca124.add(_0x5ea7e2);
    try {
      Instruction.parse(_0x5ea63c);
    } catch {
      return _0x5af6cc + ": no instruction at base+rva";
    }
    return _0x5ea63c;
  }
  function _0x137ef3(_0x4efbf1) {
    let _0x11be24 = _0x4efbf1.base;
    let _0x3870f4 = new Uint8Array(_0x11be24.readByteArray(4));
    if (_0x3870f4[0] !== 127 || _0x3870f4[1] !== 69 || _0x3870f4[2] !== 76 || _0x3870f4[3] !== 70) {
      throw new Error(_0x4efbf1.name + " base is not an ELF image");
    }
    let _0x2fa490 = Number(_0x11be24.add(32).readU64());
    let _0xb2a0e9 = _0x11be24.add(54).readU16();
    let _0x5a5fc1 = _0x11be24.add(56).readU16();
    if (_0x2fa490 <= 0 || _0xb2a0e9 < 56 || _0x5a5fc1 === 0 || _0x5a5fc1 > 128) {
      throw new Error(_0x4efbf1.name + " has an invalid ELF program header table");
    }
    let _0xf05c55 = [];
    for (let _0x364979 = 0; _0x364979 < _0x5a5fc1; _0x364979++) {
      let _0x2bcd40 = _0x11be24.add(_0x2fa490 + _0x364979 * _0xb2a0e9);
      if (_0x2bcd40.readU32() !== 1 || (_0x2bcd40.add(4).readU32() & 1) === 0) {
        continue;
      }
      let _0x20dd74 = Number(_0x2bcd40.add(16).readU64());
      let _0x1df20d = Number(_0x2bcd40.add(40).readU64());
      if (_0x20dd74 < 0 || _0x1df20d <= 0 || _0x20dd74 + _0x1df20d > _0x4efbf1.size) {
        throw new Error(_0x4efbf1.name + " executable segment is outside the mapped module");
      }
      _0xf05c55.push({
        start: _0x11be24.add(_0x20dd74),
        size: _0x1df20d
      });
    }
    if (_0xf05c55.length === 0) {
      throw new Error(_0x4efbf1.name + " has no executable ELF segment");
    }
    return _0xf05c55;
  }
  function _0x2e0bba(_0x3a4b71, _0x5aa451, _0x3d2caf, _0x4de027) {
    if (_0x3d2caf <= 0 || _0x3d2caf >= _0x3a4b71.size) {
      return _0x4de027 + ": the address is outside " + _0x3a4b71.name;
    }
    let _0x29904a = _0x3a4b71.base.add(_0x3d2caf);
    let _0x1ee771 = false;
    for (let _0x3a35d3 of _0x5aa451) {
      if (_0x29904a.compare(_0x3a35d3.start) >= 0 && _0x29904a.compare(_0x3a35d3.start.add(_0x3a35d3.size)) < 0) {
        _0x1ee771 = true;
        break;
      }
    }
    if (!_0x1ee771) {
      return _0x4de027 + ": the address is outside an executable ELF segment";
    }
    try {
      Instruction.parse(_0x29904a);
    } catch {
      return _0x4de027 + ": no ARM64 instruction at base+rva";
    }
    return _0x29904a;
  }
  function _0x1634af(_0x43017d, _0x3160bc) {
    if ((_0x3160bc & 4227858432) >>> 0 !== 2483027968) {
      return null;
    }
    let _0x1027a1 = _0x3160bc & 67108863;
    if ((_0x1027a1 & 33554432) !== 0) {
      _0x1027a1 -= 67108864;
    }
    return _0x43017d.add(_0x1027a1 * 4);
  }
  function _0x4c14a7(_0x104939, _0x3a89e3) {
    if ((_0x3a89e3 & 4227858432) >>> 0 !== 335544320) {
      return null;
    }
    let _0x2d22d5 = _0x3a89e3 & 67108863;
    if ((_0x2d22d5 & 33554432) !== 0) {
      _0x2d22d5 -= 67108864;
    }
    return _0x104939.add(_0x2d22d5 * 4);
  }
  function _0x109b56(_0x599b27, _0x386093) {
    for (let _0x5d4220 of _0x386093) {
      if (_0x599b27.compare(_0x5d4220.start) >= 0 && _0x599b27.compare(_0x5d4220.start.add(_0x5d4220.size)) < 0) {
        return true;
      }
    }
    return false;
  }
  function _0x5b8db7(_0xa83f0b) {
    if (!_0x52d1d0 || _0x578e43.length > 32) {
      return false;
    } else {
      _0x578e43.push(_0xa83f0b);
      return true;
    }
  }
  function _0x4588fc(_0xa45761) {
    let _0x52e86c = _0x9ca124.add(_0xa45761).readPointer();
    if (_0x52e86c.isNull() || !_0x52e86c.and(1).isNull()) {
      return NULL;
    } else {
      return _0x52e86c;
    }
  }
  function _0x35e499(_0xbfd78c, _0x307e93) {
    let off = off;
    if (off === null || off.klassStaticFields === undefined) {
      return NULL;
    }
    let _0x201db9 = _0x4588fc(_0xbfd78c);
    if (_0x201db9.isNull()) {
      return NULL;
    }
    let klassStaticFieldsPtr = _0x201db9.add(off.klassStaticFields).readPointer();
    if (klassStaticFieldsPtr.isNull()) {
      return NULL;
    } else {
      return klassStaticFieldsPtr.add(_0x307e93).readPointer();
    }
  }
  var _0x479475 = false;
  var _0x42ca90 = [];
  var _0x55ce49 = "offsets not applied";
  var _0x32d5da = NULL;
  var _0x1893e5 = null;
  var _0x4d496f = null;
  var _0x232e48 = null;
  var _0x458c2c = null;
  var _0x4b0668 = null;
  var _0x340bf0 = null;
  function _0x1eaf2e() {
    if (_0x1893e5 !== null) {
      _0x1893e5.detach();
      _0x1893e5 = null;
    }
    _0x479475 = false;
    _0x32d5da = NULL;
    _0x67647e = null;
    _0x4d496f = null;
    _0x232e48 = null;
    _0x458c2c = null;
    _0x4b0668 = null;
    _0x340bf0 = null;
  }
  function _0x57cf23() {
    let off = off;
    let _0xb6bc34 = _0xa44dd5(off, KEYS_PARTY);
    if (_0xb6bc34.length > 0) {
      _0x42ca90 = _0xb6bc34;
      _0x55ce49 = "offsets missing";
      return false;
    }
    _0x42ca90 = [];
    let _0x1e8449 = _0x524517(off.tiPartyManager, "PartyManager.TypeInfo");
    if (_0x1e8449 !== null) {
      _0x55ce49 = _0x1e8449;
      return false;
    }
    let _0x307976 = [{
      rva: off.rvaPartyMemberCount,
      what: "PartyManager.get_MemberCount"
    }, {
      rva: off.rvaPartyMemberPlayerId,
      what: "PartyManager.GetMemberPlayerId"
    }, {
      rva: off.rvaPlayerGetPlayer,
      what: "PlayerHandler.GetPlayer"
    }, {
      rva: off.rvaSelectRemotePlayer,
      what: "PlayerEnemyClicker.SelectRemotePlayer"
    }, {
      rva: off.rvaSelectSelf,
      what: "PlayerEnemyClicker.SelectSelf"
    }, {
      rva: off.rvaAtkAnchor,
      what: "PlayerEnemyClicker.FixedUpdate"
    }];
    for (let _0x2f0aaf of _0x307976) {
      let _0x194782 = _0x3166d6(_0x2f0aaf.rva, _0x2f0aaf.what);
      if (typeof _0x194782 == "string") {
        _0x55ce49 = _0x194782;
        return false;
      }
    }
    _0x4d496f = new NativeFunction(_0x9ca124.add(off.rvaPartyMemberCount), "int", ["pointer", "pointer"]);
    _0x232e48 = new NativeFunction(_0x9ca124.add(off.rvaPartyMemberPlayerId), "int", ["pointer", "int", "pointer"]);
    _0x458c2c = new NativeFunction(_0x9ca124.add(off.rvaPlayerGetPlayer), "pointer", ["pointer", "uint16", "pointer"]);
    _0x4b0668 = new NativeFunction(_0x9ca124.add(off.rvaSelectRemotePlayer), "void", ["pointer", "pointer", "pointer"]);
    _0x340bf0 = new NativeFunction(_0x9ca124.add(off.rvaSelectSelf), "void", ["pointer", "pointer", "pointer"]);
    _0x1893e5 = Interceptor.attach(_0x9ca124.add(off.rvaAtkAnchor), {
      onEnter(args) {
        _0x32d5da = args[0];
      }
    });
    _0x55ce49 = "";
    return true;
  }
  function _0x3adf33() {
    _0x67647e = null;
    if (!_0x479475 || off === null || _0x298ea0.isNull()) {
      return null;
    }
    let off = off;
    try {
      let _0x54cf3e = _0x35e499(off.tiPartyManager, off.partyInstance);
      if (_0x54cf3e.isNull()) {
        return null;
      }
      let _0x286313 = _0x4d496f(_0x54cf3e, NULL);
      if (!Number.isInteger(_0x286313) || _0x286313 < 0 || _0x286313 > 32) {
        return null;
      }
      let _0x3fd8d6 = [];
      for (let _0xf3079e = 0; _0xf3079e < _0x286313; _0xf3079e++) {
        let _0x8c585c = _0x232e48(_0x54cf3e, _0xf3079e, NULL);
        if (_0x8c585c < 1 || _0x8c585c > 65535 || _0x3fd8d6.indexOf(_0x8c585c) >= 0) {
          return null;
        }
        _0x3fd8d6.push(_0x8c585c);
      }
      _0x67647e = _0x3fd8d6;
      return _0x3fd8d6;
    } catch {
      return null;
    }
  }
  function _0xb1069e(_0x4ff2a0) {
    if (_0x4ff2a0 === null || off === null || _0x298ea0.isNull() || _0x458c2c === null) {
      return null;
    }
    let off = off;
    let _0x59030d = [];
    for (let _0x388b2d of _0x4ff2a0) {
      try {
        let _0x25cf23 = _0x458c2c(_0x298ea0, _0x388b2d, NULL);
        if (_0x25cf23.isNull() || _0x25cf23.add(off.unitGaeaId).readU16() !== _0x388b2d || _0x25cf23.add(off.unitSelf).readPointer().isNull()) {
          continue;
        }
        _0x59030d.push(_0x388b2d);
      } catch {}
    }
    return _0x59030d;
  }
  function _0x4cd8d9(_0x354dae, _0x683675) {
    let _0x1a9c1a = (_0x40fd48, _0x80a209) => send({
      t: "party_select",
      ok: _0x40fd48,
      id: _0x354dae,
      self: _0x683675,
      verified: false,
      error: _0x80a209
    });
    if (!_0x479475 || off === null) {
      _0x1a9c1a(false, "party offsets not loaded");
      return;
    }
    if (!_0x683675 && (!Number.isInteger(_0x354dae) || _0x354dae < 1 || _0x354dae > 65535)) {
      _0x1a9c1a(false, "invalid player id");
      return;
    }
    if (!_0x5b8db7(() => {
      try {
        if (_0x298ea0.isNull() || _0x32d5da.isNull()) {
          _0x1a9c1a(false, "player handler or clicker unavailable");
          return;
        }
        let off = off;
        let _0x58b040 = NULL;
        if (_0x683675) {
          let _0x267993 = _0x42437c(_0x298ea0.add(off.phPlayers).readPointer());
          for (let _0x127f73 of _0x267993) {
            if (_0x127f73.add(off.unitIsSelf).readU8() !== 0) {
              _0x58b040 = _0x127f73;
              break;
            }
          }
        } else {
          let _0x2fbb44 = _0x3adf33();
          if (_0x2fbb44 === null || _0x2fbb44.indexOf(_0x354dae) < 0) {
            _0x1a9c1a(false, "player is not in the current party roster");
            return;
          }
          _0x58b040 = _0x458c2c(_0x298ea0, _0x354dae, NULL);
          if (!_0x58b040.isNull() && _0x58b040.add(off.unitGaeaId).readU16() !== _0x354dae) {
            _0x58b040 = NULL;
          }
        }
        if (_0x58b040.isNull()) {
          _0x1a9c1a(false, "player is not visible");
          return;
        }
        let unitSelfPtr = _0x58b040.add(off.unitSelf).readPointer();
        if (unitSelfPtr.isNull()) {
          _0x1a9c1a(false, "player game object unavailable");
          return;
        }
        if (_0x683675) {
          _0x340bf0(_0x32d5da, unitSelfPtr, NULL);
        } else {
          _0x4b0668(_0x32d5da, _0x58b040, NULL);
        }
        _0x1a9c1a(true, "");
      } catch (_0x28d96f) {
        _0x1a9c1a(false, "" + _0x28d96f);
      }
    })) {
      _0x1a9c1a(false, "frame queue unavailable");
    }
  }
  function _0x5a73cb() {
    let _0x547602 = off;
    if (_0x547602 !== null) {
      _0x15d7f3.beginHookSample(Date.now());
      if (_0x33d100 && _0x3be0a9 !== null) {
        try {
          let off = _0x547602;
          let _0x302fd8 = _0x35e499(off.tiMultiSceneHelper, off.mshInstance);
          if (!_0x302fd8.isNull()) {
            let _0x54bf0c = _0x16d145([() => {
              let mshLoaderPtr = _0x302fd8.add(off.mshLoader).readPointer();
              if (mshLoaderPtr.isNull()) {
                return null;
              }
              let loaderCanvasPtr = mshLoaderPtr.add(off.loaderCanvas).readPointer();
              if (loaderCanvasPtr.isNull()) {
                return null;
              } else {
                return _0x3be0a9(loaderCanvasPtr, NULL) !== 0;
              }
            }, () => {
              let mshFirstLoaderPtr = _0x302fd8.add(off.mshFirstLoader).readPointer();
              if (mshFirstLoaderPtr.isNull()) {
                return null;
              }
              let loaderCanvasPtr = mshFirstLoaderPtr.add(off.loaderCanvas).readPointer();
              if (loaderCanvasPtr.isNull()) {
                return null;
              } else {
                return _0x3be0a9(loaderCanvasPtr, NULL) !== 0;
              }
            }]);
            if (_0x54bf0c.value !== null) {
              _0x15d7f3.observeLoading(_0x54bf0c.value, _0x54bf0c.source);
            }
          }
        } catch {}
      }
      if (_0x3845a7 && _0x441c68 !== null && !_0x390ac2.isNull()) {
        try {
          _0x15d7f3.observeDead(_0x441c68(_0x390ac2, NULL) !== 0);
        } catch {}
      }
    }
  }
  function _0x524517(_0x162eaf, _0x4ae117) {
    if (_0x162eaf <= 0 || _0x162eaf >= _0xdb6669) {
      return _0x4ae117 + ": the address is outside the module";
    } else if (_0x162eaf % Process.pointerSize !== 0) {
      return _0x4ae117 + ": the address is not pointer-aligned";
    } else {
      return null;
    }
  }
  function _0xa44dd5(_0x1706c4, _0x1a4395) {
    let _0x5410f5 = [];
    for (let _0x4d6b3b = 0; _0x4d6b3b < _0x1a4395.length; _0x4d6b3b++) {
      let _0x442cbd = _0x1706c4[_0x1a4395[_0x4d6b3b]];
      if (KEYS_OPTIONAL.indexOf(_0x1a4395[_0x4d6b3b]) >= 0) {
        if (typeof _0x442cbd != "number") {
          _0x5410f5.push(_0x1a4395[_0x4d6b3b]);
        }
      } else if (!_0x442cbd) {
        _0x5410f5.push(_0x1a4395[_0x4d6b3b]);
      }
    }
    return _0x5410f5;
  }
  function _0x426d3b() {
    for (let _0x2a2a69 of _0xcd8a73) {
      try {
        _0x2a2a69.detach();
      } catch {}
    }
    _0xcd8a73 = [];
  }
  function _0x3583ff(_0x4aa947, off) {
    let bcImageLen = _0x4aa947.add(off.bcImageLen).readU16();
    if (bcImageLen > 8192) {
      throw new Error("challenge image is too large");
    }
    let bcImagePtr = _0x4aa947.add(off.bcImage).readPointer();
    if (bcImagePtr.isNull()) {
      throw new Error("challenge image is unavailable");
    }
    if (bcImageLen > bcImagePtr.add(off.arrCount).readU32()) {
      throw new Error("challenge image is truncated");
    }
    let arrFirst = bcImagePtr.add(off.arrFirst).readByteArray(bcImageLen);
    if (arrFirst === null) {
      throw new Error("challenge image copy failed");
    }
    return arrFirst;
  }
  function _0x345dfd(_0xf6b199, off) {
    if (_0xf6b199.isNull()) {
      return "";
    }
    let strLen = _0xf6b199.add(off.strLen).readS32();
    if (strLen < 0 || strLen > 8) {
      throw new Error("challenge answer length is invalid");
    }
    return _0xf6b199.add(off.strChars).readUtf16String(strLen) ?? "";
  }
  function _0x86889e() {
    let off = off;
    let _0x1cddee = _0xa44dd5(off, KEYS_BOT_CHALLENGE);
    if (_0x1cddee.length > 0) {
      _0x43b4ce = _0x1cddee;
      _0x46bd97 = "offsets missing";
      return false;
    }
    _0x43b4ce = [];
    let _0x43a68f = [{
      rva: off.rvaChallengeIncoming,
      what: "ServerConnectionManager.HandleBotChallenge"
    }, {
      rva: off.rvaChallengeSubmission,
      what: "ServerConnectionManager.SendBotChallengeAnswer"
    }, {
      rva: off.rvaChallengeResult,
      what: "ServerConnectionManager.HandleBotChallengeResult"
    }];
    for (let _0xc7ec2e of _0x43a68f) {
      let _0x21f28e = _0x3166d6(_0xc7ec2e.rva, _0xc7ec2e.what);
      if (typeof _0x21f28e == "string") {
        _0x46bd97 = _0x21f28e;
        return false;
      }
    }
    _0x426d3b();
    try {
      _0xcd8a73.push(Interceptor.attach(_0x9ca124.add(off.rvaChallengeIncoming), {
        onEnter(args) {
          if (!!_0x3b379a && off !== null) {
            try {
              let off2 = off;
              let _0x467be6 = args[1];
              let _0x5d52cf = _0x3583ff(_0x467be6, off2);
              send(_0x47dfcc({
                challengeId: _0x467be6.add(off2.bcChallengeId).readU32(),
                challengeType: _0x467be6.add(off2.bcChallengeType).readU8(),
                timeoutSec: _0x467be6.add(off2.bcTimeoutSec).readU8(),
                attemptsLeft: _0x467be6.add(off2.bcAttemptsLeft).readU8(),
                imageLen: _0x467be6.add(off2.bcImageLen).readU16(),
                receivedUnixMs: Date.now()
              }), _0x5d52cf);
            } catch {}
          }
        }
      }));
      _0xcd8a73.push(Interceptor.attach(_0x9ca124.add(off.rvaChallengeSubmission), {
        onEnter(args) {
          if (!!_0x3b379a && off !== null) {
            try {
              send(_0x876f4a(args[1].toUInt32(), _0x345dfd(args[2], off), Date.now()));
            } catch {}
          }
        }
      }));
      _0xcd8a73.push(Interceptor.attach(_0x9ca124.add(off.rvaChallengeResult), {
        onEnter(args) {
          if (!!_0x3b379a && off !== null) {
            try {
              let off2 = off;
              let _0x4f54cf = args[1];
              send(_0x19a4a4(_0x4f54cf.add(off2.bcrChallengeId).readU32(), _0x4f54cf.add(off2.bcrResult).readU8(), _0x4f54cf.add(off2.bcrAttemptsLeft).readU8(), Date.now()));
            } catch {}
          }
        }
      }));
    } catch {
      _0x426d3b();
      _0x46bd97 = "challenge hook installation failed";
      return false;
    }
    _0xed018 = new NativeFunction(_0x9ca124.add(off.rvaChallengeSubmission), "void", ["pointer", "uint", "pointer", "pointer"]);
    _0x46bd97 = "";
    return true;
  }
  function _0x5dda7f(_0x484977, _0x2f4277, _0x22dbfb) {
    let _0x264886 = _0xc1f0e1(_0x2f4277, _0x22dbfb);
    if (_0x264886 !== null) {
      send({
        t: "challenge_answer_reply",
        req: _0x484977,
        ok: false,
        error: _0x264886
      });
      return;
    }
    if (!_0x5b8db7(() => {
      try {
        let off = off;
        let _0x205e5f = _0x53c8d0;
        let scmZoneConnectionPtr = _0x205e5f.add(off.scmZoneConnection).readPointer();
        if (_0x205e5f.isNull() || scmZoneConnectionPtr.isNull()) {
          throw new Error("zone connection is unavailable; answer was not sent");
        }
        let _0x1799b8 = _0xc5f073(Memory.allocUtf8String(_0x22dbfb));
        if (_0x1799b8.isNull()) {
          throw new Error("could not allocate the answer string");
        }
        _0xed018(_0x205e5f, _0x2f4277, _0x1799b8, NULL);
        send(_0x876f4a(_0x2f4277, _0x22dbfb, Date.now()));
        send({
          t: "challenge_answer_reply",
          req: _0x484977,
          ok: true,
          error: ""
        });
      } catch (_0x1c820d) {
        send({
          t: "challenge_answer_reply",
          req: _0x484977,
          ok: false,
          error: "" + _0x1c820d
        });
      }
    })) {
      send({
        t: "challenge_answer_reply",
        req: _0x484977,
        ok: false,
        error: "no frame hook or queue full"
      });
    }
  }
  function _0xc1f0e1(_0x15ee7e, _0x4df6ad) {
    if (_0x3b379a) {
      if (_0x52d1d0) {
        if (_0x53c8d0.isNull()) {
          return "no ServerConnectionManager instance";
        } else if (!Number.isInteger(_0x15ee7e) || _0x15ee7e <= 0 || _0x15ee7e > 4294967295) {
          return "challengeId is invalid";
        } else if (typeof _0x4df6ad != "string" || !/^[0-9]{1,8}$/.test(_0x4df6ad)) {
          return "answer must be 1-8 ascii digits";
        } else {
          return null;
        }
      } else {
        return "no frame hook";
      }
    } else {
      return "challenge hooks are not ready" + (_0x46bd97 ? ": " + _0x46bd97 : "");
    }
  }
  function _0x38918f(_0x58e809) {
    _0x10aaed(_0x58e809);
    _0x2c71d4(_0x58e809);
    _0x3b379a = false;
    _0x426d3b();
    _0x43b4ce = [];
    _0x46bd97 = _0x58e809;
    off = null;
    _0x9ca124 = NULL;
    _0xdb6669 = 0;
    _0x44669c = false;
    _0x43c9d6 = false;
    _0x8ea0f0 = [];
    _0x54bde4 = [];
    _0x18794e = [];
    _0x74250c = _0x58e809;
    _0x46bd9a = _0x58e809;
    _0x569b58 = false;
    _0x27f61a = [];
    _0x43e1e6 = null;
    _0x351656 = null;
    _0x3aa646 = false;
    _0x8b4a0e = null;
    _0x50cd59 = NULL;
    _0x42cbb7 = null;
    _0x33963e = {};
    if (_0x548284 !== null) {
      _0x548284.suspend();
    }
    _0x548284 = null;
    _0x369dae = false;
    _0x4856fe = 0;
    _0x120c62 = false;
    _0x38ac97 = NULL;
    _0x4af91f = [];
    _0x5aa6c0 = _0x58e809;
    _0xafd509 = null;
    _0x256353 = null;
    _0xc2356e = null;
    _0x1ca03c = false;
    _0x329721();
    _0x16d9be = NULL;
    _0x561396 = [];
    _0xcf39b4 = _0x58e809;
    _0x3493d7 = null;
    _0x8b33cc = null;
    _0x5a3803 = null;
    _0xdefa3c = null;
    _0x53e867 = null;
    _0x3b52d3 = null;
    _0x1eaf2e();
    _0x42ca90 = [];
    _0x55ce49 = _0x58e809;
    _0xfeda7a = false;
    _0x4b1dc0();
    _0x5e47fc = NULL;
    _0xf43ce = "";
    _0x21193b = [];
    _0x11dcc0 = _0x58e809;
    _0x4b666c = null;
    _0x394502 = null;
    _0x4ce11e = null;
    _0x210b66 = false;
    _0x20d6eb();
    _0x53c8d0 = NULL;
    _0x51bb09 = [];
    _0x511771 = _0x58e809;
    _0x1e0539 = null;
    _0x36d806(_0x58e809);
    _0x33d100 = false;
    _0x2ea383 = [];
    _0x3821d4 = _0x58e809;
    _0x15d7f3.reset();
    _0x3be0a9 = null;
    _0x3845a7 = false;
    _0x598183 = [];
    _0xa669d5 = _0x58e809;
    _0x441c68 = null;
    _0x52cd94 = null;
    _0x27c34b = null;
    _0x2dbd2e = null;
    _0x41bf4e = null;
    _0x4f68f0 = null;
    let _0xae70ac = _0x176816.reset();
    if (_0xae70ac !== null) {
      _0x180e35(_0xae70ac, false, null, _0x58e809);
    }
    if (_0x3980f1 !== null) {
      clearTimeout(_0x3980f1);
      _0x3980f1 = null;
    }
    _0x526164 = false;
    _0x26d215 = [];
    _0x207859 = _0x58e809;
    _0xaba49a = null;
    if (_0x52c8c6 !== null) {
      _0x20ad63(_0x58e809);
    }
    _0x4c024d = false;
    _0x40d52d = [];
    _0x37d827 = _0x58e809;
    _0x3f745b = null;
    _0x528654 = false;
    _0x345e5a = [];
    _0x3924ee = _0x58e809;
    _0x24fb9b = null;
    _0x17a10c = false;
    _0x4901c7 = [];
    _0x3f3713 = _0x58e809;
    _0x148505 = null;
    _0x552ea7 = null;
    _0x171e7b = null;
    _0x44b3ec = NULL;
    imgFillAmount = -1;
    _0x5b7018 = 0;
    _0x5f0b61 = 0;
    _0x3a3a4d = 0;
    _0x923b4d = false;
    _0x48b995 = [];
    _0x1704dc = _0x58e809;
    _0x5f4082 = false;
    _0x455844 = [];
    _0x18b634 = _0x58e809;
    _0x590e9e = null;
    _0x393129 = null;
    _0x545f85 = false;
    _0x18c945 = [];
    _0x5590df = _0x58e809;
    _0x5a95f5 = null;
    _0x58f4ec = false;
    _0x6a2faf = [];
    _0x29f4e4 = _0x58e809;
    _0x4b9447 = null;
    _0x53b669 = 0;
    _0x4fbebf = false;
    _0x392a93 = [];
    _0x1293d9 = _0x58e809;
    _0xab855f.reset();
    _0x5a5014.clear();
    _0x5788d6 = NULL;
    _0x5749bd = NULL;
    _0x3f6352 = NULL;
    _0x548f62 = false;
    _0x257f0c();
    send({
      t: "offsets",
      ok: false,
      error: _0x58e809,
      requiredMissing: _0x2508e4
    });
  }
  function _0x14acb5(_0x11c568) {
    _0x1296cb(_0x11c568.trace === true);
    _0x13ee08("offsets: applying");
    let off = _0x11c568.off;
    _0x2508e4 = _0xa44dd5(off, KEYS_CORE);
    if (_0x2508e4.length > 0) {
      _0x38918f("offsets missing: " + _0x2508e4.join(", "));
      return;
    }
    let _0x5292cb = Process.findModuleByName(off.module);
    if (_0x5292cb === null) {
      _0x38918f("module not found: " + off.module);
      return;
    }
    off = off;
    _0x9ca124 = _0x5292cb.base;
    _0xdb6669 = _0x5292cb.size;
    _0x3b379a = false;
    _0x426d3b();
    _0x43b4ce = [];
    _0x46bd97 = "offsets not applied";
    _0x1eaf2e();
    _0x20d6eb();
    _0x53c8d0 = NULL;
    _0x33d100 = false;
    _0x15d7f3.reset();
    _0x3be0a9 = null;
    _0x3845a7 = false;
    _0x441c68 = null;
    _0x52cd94 = null;
    _0x27c34b = null;
    _0x2dbd2e = null;
    _0x41bf4e = null;
    _0x4f68f0 = null;
    let _0x4b8d9f = _0x176816.reset();
    if (_0x4b8d9f !== null) {
      _0x180e35(_0x4b8d9f, false, null, "offset table replaced");
    }
    if (_0x3980f1 !== null) {
      clearTimeout(_0x3980f1);
      _0x3980f1 = null;
    }
    _0x4fbebf = false;
    _0x392a93 = [];
    _0x1293d9 = "offsets not applied";
    _0xab855f.reset();
    let _0xaceded = false;
    try {
      let _0x35c780 = new Uint8Array(_0x9ca124.readByteArray(4));
      _0xaceded = _0x35c780[0] === 127 && _0x35c780[1] === 69 && _0x35c780[2] === 76 && _0x35c780[3] === 70;
    } catch {
      _0xaceded = false;
    }
    let _0x2197a5 = _0x19bad9();
    _0x44669c = _0x28ecad();
    _0x569b58 = _0x5cfc07();
    _0x43c9d6 = _0x269cab();
    _0x3aa646 = _0x42242d();
    _0x2a51b7 = _0x3dedea();
    _0x120c62 = _0x160529();
    _0x1ca03c = _0x2f93a2();
    _0x479475 = _0x57cf23();
    _0xfeda7a = _0x5e57c8();
    _0x210b66 = _0x46f24a();
    _0x33d100 = _0x2141aa();
    _0x3845a7 = _0x4f7614();
    _0x4fbebf = _0x426466();
    _0x17a10c = _0x3c303e();
    _0x923b4d = _0x41f261();
    _0x5f4082 = _0x27d064();
    _0x545f85 = _0x357a28();
    _0x120702 = _0x42b772();
    _0x3b379a = _0x86889e();
    _0x526164 = _0x55be7c();
    _0x4c024d = _0x15d0cb();
    _0x58f4ec = _0x1ddb01();
    _0x528654 = _0x5e643d();
    _0x10aaed("classic zone selected");
    send({
      t: "offsets",
      ok: _0x2197a5 == null,
      error: _0x2197a5 ?? "",
      module: off.module,
      base: _0x9ca124.toString(),
      size: _0xdb6669,
      elf: _0xaceded,
      unityVersion: off.unityVersion,
      versionCode: off.versionCode,
      radarReady: _0x371e20,
      radarMissing: _0xf44ff4,
      radarReason: _0x4ed5f9,
      fogReady: _0x2a51b7,
      fogMissing: _0x35f8bb,
      fogReason: _0x294766,
      zoneReady: _0x44669c,
      w2sReady: _0x43c9d6,
      camReady: _0x3aa646,
      slotReady: _0x120c62,
      atkReady: _0x1ca03c,
      skillReady: _0xfeda7a,
      pickReady: _0x210b66,
      zonetopReady: _0x569b58,
      loadingReady: _0x33d100,
      rebirthReady: _0x3845a7,
      identityReady: _0x4fbebf,
      requiredMissing: _0x2508e4,
      zoneMissing: _0x8ea0f0,
      w2sMissing: _0x54bde4,
      camMissing: _0x18794e,
      slotMissing: _0x4af91f,
      atkMissing: _0x561396,
      skillMissing: _0x21193b,
      pickMissing: _0x51bb09,
      zonetopMissing: _0x27f61a,
      loadingMissing: _0x2ea383,
      rebirthMissing: _0x598183,
      identityMissing: _0x392a93,
      zoneReason: _0x74250c,
      camReason: _0x46bd9a,
      slotReason: _0x5aa6c0,
      atkReason: _0xcf39b4,
      skillReason: _0x11dcc0,
      pickReason: _0x511771,
      loadingReason: _0x3821d4,
      rebirthReason: _0xa669d5,
      identityReason: _0x1293d9,
      boxtimeReady: _0x17a10c,
      boxtimeMissing: _0x4901c7,
      boxtimeReason: _0x3f3713,
      tabfileReady: _0x923b4d,
      tabfileMissing: _0x48b995,
      tabfileReason: _0x1704dc,
      rebuffReady: _0x5f4082,
      rebuffMissing: _0x455844,
      rebuffReason: _0x18b634,
      bagReady: _0x545f85,
      bagMissing: _0x18c945,
      bagReason: _0x5590df,
      petReady: _0x120702,
      petMissing: _0x335116,
      petReason: _0x38c3ed,
      challengeReady: _0x3b379a,
      challengeMissing: _0x43b4ce,
      challengeReason: _0x46bd97,
      sellReady: _0x526164,
      sellMissing: _0x26d215,
      sellReason: _0x207859,
      recallReady: _0x4c024d,
      recallMissing: _0x40d52d,
      recallReason: _0x37d827,
      friendWarpReady: _0x528654,
      friendWarpMissing: _0x345e5a,
      friendWarpReason: _0x3924ee,
      friendsReady: _0x58f4ec,
      friendsMissing: _0x6a2faf,
      friendsReason: _0x29f4e4,
      partyReady: _0x479475,
      partyMissing: _0x42ca90,
      partyReason: _0x55ce49,
      trace: _0x49f464,
      tracePath: _0x2612f8
    });
  }
  function _0x1942a0(_0x54b6a2, _0x14b6de) {
    _0x9b1c55(_0x54b6a2);
    let _0x21710c = Math.max(1, Math.round(1000 / _0x14b6de));
    _0x2c4af2[_0x54b6a2] = setInterval(() => {
      if (_0x118409[_0x54b6a2]) {
        _0x4b6fde[_0x54b6a2]++;
        return;
      }
      if (_0x54b6a2 === "t0") {
        _0x487fe5.t0++;
        _0x118409.t0 = true;
        send({
          t: "t0",
          seq: _0x487fe5.t0,
          skipped: _0x4b6fde.t0
        }, _0x35ce2a.buffer);
        return;
      }
      if (_0x54b6a2 === "t2") {
        _0x118409.t2 = true;
        _0x467650("stream");
        return;
      }
      let _0x29e18d = _0x17c656();
      if (_0x29e18d == null) {
        return;
      }
      _0x487fe5.t1++;
      _0x118409.t1 = true;
      let _0xadcec = false;
      if (_0x49db6d) {
        _0x49db6d = false;
        _0x313980 = Date.now();
        _0xadcec = true;
      }
      send({
        t: "snap",
        seq: _0x487fe5.t1,
        skipped: _0x4b6fde.t1,
        trigger: _0xadcec
      }, _0x29e18d);
    }, _0x21710c);
  }
  function _0x9b1c55(_0x3f6265) {
    if (_0x2c4af2[_0x3f6265] != null) {
      clearInterval(_0x2c4af2[_0x3f6265]);
      _0x2c4af2[_0x3f6265] = null;
    }
    _0x118409[_0x3f6265] = false;
  }
  function _0x441dbb(_0x221804) {
    if (_0x36ddc8 != null) {
      clearInterval(_0x36ddc8);
    }
    _0x36ddc8 = setInterval(() => {
      _0x109497++;
      _0x4c6f1e[_0x109497] = Date.now();
      send({
        t: "ping",
        seq: _0x109497
      });
    }, Math.max(1, Math.round(1000 / _0x221804)));
  }
  function _0x1b5e60(_0x249b08) {
    if (_0x5c8599 != null) {
      clearInterval(_0x5c8599);
    }
    _0x5c8599 = setInterval(() => {
      let _0x10c3b2 = Date.now();
      if (!_0x5b8db7(() => send({
        t: "mt",
        wait_ms: Date.now() - _0x10c3b2
      }))) {
        send({
          t: "mt",
          busy: true
        });
      }
    }, Math.max(1, Math.round(1000 / _0x249b08)));
  }
  function _0x2f4e0c(_0x1b2b82, _0x40e830) {
    try {
      let _0x498582 = _0x1b2b82.findExportByName(_0x40e830);
      if (_0x498582 !== null && !_0x498582.isNull()) {
        return _0x498582;
      }
    } catch {}
    try {
      let _0x1d1499 = Module.findExportByName(_0x1b2b82.name, _0x40e830);
      if (_0x1d1499 !== null && !_0x1d1499.isNull()) {
        return _0x1d1499;
      }
    } catch {}
    return NULL;
  }
  function _0x33ac51() {
    let _0x5571fe = Process.findModuleByName(off.module);
    if (_0x5571fe === null) {
      return false;
    }
    let _0x2a499c = _0x11332a => _0x2f4e0c(_0x5571fe, _0x11332a);
    let _0x5b77f7 = _0x2a499c("il2cpp_domain_get");
    let _0x160e8a = _0x2a499c("il2cpp_domain_assembly_open");
    let _0x250516 = _0x2a499c("il2cpp_assembly_get_image");
    let _0x59f808 = _0x2a499c("il2cpp_class_from_name");
    let _0x70120b = _0x2a499c("il2cpp_class_get_type");
    let _0x511b33 = _0x2a499c("il2cpp_type_get_object");
    let _0x4877fb = _0x2a499c("il2cpp_object_new");
    let _0x4c7c2f = _0x2a499c("il2cpp_array_new");
    let _0x38a246 = _0x2a499c("il2cpp_string_new");
    let _0x380901 = _0x2a499c("il2cpp_gchandle_new");
    if (_0x5b77f7.isNull() || _0x4877fb.isNull() || _0x4c7c2f.isNull() || _0x38a246.isNull() || _0x380901.isNull() || _0x59f808.isNull()) {
      return false;
    } else {
      _0x4467b3 = new NativeFunction(_0x5b77f7, "pointer", []);
      _0x23b312 = new NativeFunction(_0x160e8a, "pointer", ["pointer", "pointer"]);
      _0x3565c8 = new NativeFunction(_0x250516, "pointer", ["pointer"]);
      _0x214aab = new NativeFunction(_0x59f808, "pointer", ["pointer", "pointer", "pointer"]);
      _0x4d38be = new NativeFunction(_0x70120b, "pointer", ["pointer"]);
      _0x80b027 = new NativeFunction(_0x511b33, "pointer", ["pointer"]);
      _0x4d4f06 = new NativeFunction(_0x4877fb, "pointer", ["pointer"]);
      _0x2e9b66 = new NativeFunction(_0x4c7c2f, "pointer", ["pointer", "int"]);
      _0xc5f073 = new NativeFunction(_0x38a246, "pointer", ["pointer"]);
      _0xc1f0b3 = new NativeFunction(_0x380901, "int", ["pointer", "int"]);
      return true;
    }
  }
  function _0x486d4b(_0x150240, _0x5cd7b6, _0x373f99) {
    if (_0x4467b3 === null || _0x23b312 === null || _0x3565c8 === null || _0x214aab === null || _0x4d38be === null || _0x80b027 === null) {
      return NULL;
    }
    let _0x4d9a42 = _0x4467b3();
    if (_0x4d9a42.isNull()) {
      return NULL;
    }
    let _0xbd2c77 = Memory.allocUtf8String(_0x150240);
    let _0x1bbbc8 = _0x23b312(_0x4d9a42, _0xbd2c77);
    if (_0x1bbbc8.isNull()) {
      return NULL;
    }
    let _0x5e1e8d = _0x3565c8(_0x1bbbc8);
    if (_0x5e1e8d.isNull()) {
      return NULL;
    }
    let _0x207531 = Memory.allocUtf8String(_0x5cd7b6);
    let _0x5dd5de = Memory.allocUtf8String(_0x373f99);
    let _0x42c9f3 = _0x214aab(_0x5e1e8d, _0x207531, _0x5dd5de);
    if (_0x42c9f3.isNull()) {
      return NULL;
    }
    let _0x31bb8d = _0x4d38be(_0x42c9f3);
    if (_0x31bb8d.isNull()) {
      return NULL;
    } else {
      return _0x80b027(_0x31bb8d);
    }
  }
  function _0x28ecad() {
    let off2 = off;
    let _0x280b76 = _0xa44dd5(off2, KEYS_MESH);
    if (_0x280b76.length > 0) {
      _0x8ea0f0 = _0x280b76;
      _0x74250c = "offsets missing";
      return false;
    } else {
      _0x8ea0f0 = [];
      if (_0x33ac51()) {
        _0x74250c = "";
        _0x32ddda = new NativeFunction(_0x9ca124.add(off2.rvaMeshCtor), "void", ["pointer", "pointer"]);
        _0x9c1407 = new NativeFunction(_0x9ca124.add(off2.rvaMeshSetVertices), "void", ["pointer", "pointer", "pointer"]);
        _0x50671e = new NativeFunction(_0x9ca124.add(off2.rvaMeshSetTriangles), "void", ["pointer", "pointer", "pointer"]);
        _0x3f4ff3 = new NativeFunction(_0x9ca124.add(off2.rvaMeshSetColors), "void", ["pointer", "pointer", "pointer"]);
        _0x2522df = new NativeFunction(_0x9ca124.add(off2.rvaMeshGetVertexCount), "int", ["pointer", "pointer"]);
        _0x1cf549 = new NativeFunction(_0x9ca124.add(off2.rvaMeshFilterSetMesh), "void", ["pointer", "pointer", "pointer"]);
        _0x39ae42 = new NativeFunction(_0x9ca124.add(off2.rvaRendererSetMaterial), "void", ["pointer", "pointer", "pointer"]);
        _0x68f14c = new NativeFunction(_0x9ca124.add(off2.rvaRendererSetEnabled), "void", ["pointer", "int", "pointer"]);
        _0x3ecfea = new NativeFunction(_0x9ca124.add(off2.rvaGameObjectCtor), "void", ["pointer", "pointer", "pointer"]);
        _0x1c5718 = new NativeFunction(_0x9ca124.add(off2.rvaGameObjectAddComponent), "pointer", ["pointer", "pointer", "pointer"]);
        _0x20c223 = new NativeFunction(_0x9ca124.add(off2.rvaGameObjectGetLayer), "int", ["pointer", "pointer"]);
        _0x416720 = new NativeFunction(_0x9ca124.add(off2.rvaGameObjectSetLayer), "void", ["pointer", "int", "pointer"]);
        _0x484914 = new NativeFunction(_0x9ca124.add(off2.rvaComponentGetTransform), "pointer", ["pointer", "pointer"]);
        _0x5212d5 = new NativeFunction(_0x9ca124.add(off2.rvaComponentGetGameObject), "pointer", ["pointer", "pointer"]);
        _0x5d8775 = new NativeFunction(_0x9ca124.add(off2.rvaTransformSetParent), "void", ["pointer", "pointer", "pointer"]);
        _0x47e27b = new NativeFunction(_0x9ca124.add(off2.rvaTransformSetLocalPosInjected), "void", ["pointer", "pointer", "pointer"]);
        _0x3cce3b = new NativeFunction(_0x9ca124.add(off2.rvaTransformGetLossyScaleInjected), "void", ["pointer", "pointer", "pointer"]);
        _0x1ee86b = new NativeFunction(_0x9ca124.add(off2.rvaObjectDestroy), "void", ["pointer", "pointer"]);
        _0x1975a5 = new NativeFunction(_0x9ca124.add(off2.rvaShaderFind), "pointer", ["pointer", "pointer"]);
        _0x334efa = new NativeFunction(_0x9ca124.add(off2.rvaMaterialCtor), "void", ["pointer", "pointer", "pointer"]);
        return true;
      } else {
        _0x74250c = "il2cpp exports did not resolve";
        return false;
      }
    }
  }
  function _0x5cfc07() {
    let off2 = off;
    let _0x41337a = _0xa44dd5(off2, KEYS_MATERIAL);
    if (_0x41337a.length > 0) {
      _0x27f61a = _0x41337a;
      return false;
    } else {
      _0x27f61a = [];
      _0x43e1e6 = new NativeFunction(_0x9ca124.add(off2.rvaMaterialSetInt), "void", ["pointer", "pointer", "int", "pointer"]);
      _0x351656 = new NativeFunction(_0x9ca124.add(off2.rvaMaterialSetRenderQueue), "void", ["pointer", "int", "pointer"]);
      return true;
    }
  }
  function _0x3bdbda(_0x4129eb, _0x35f262) {
    if (!_0x3aa646) {
      return "camera offsets not loaded";
    }
    if (_0x50cd59.isNull()) {
      return "no Zoom instance yet";
    }
    let off2 = off;
    let _0x3e4f1 = _0x3fda91();
    for (let _0x345926 of _0x3e4f1) {
      let _0x229afd = _0x9ca124.add(off2.rvaZoomClamp + _0x345926.delta).readU32();
      if (!_0x2fba74(_0x229afd, _0x345926.was)) {
        return "clamp site +0x" + _0x345926.delta.toString(16) + " (" + _0x345926.what + ") reads 0x" + _0x229afd.toString(16) + ", not MOVZ #" + _0x345926.was + " - the method moved, re-scan";
      }
    }
    let _0x3f9690 = [];
    for (let _0x8ce830 of _0x3e4f1) {
      let _0x152f60 = _0x9ca124.add(off2.rvaZoomClamp + _0x8ce830.delta);
      let _0xdbc2e2 = _0x152f60.readU32();
      if (_0x33963e[_0x8ce830.delta] === undefined) {
        _0x33963e[_0x8ce830.delta] = _0xdbc2e2;
      }
      let _0x1c7e57 = ((_0xdbc2e2 & -2097121) >>> 0 | (_0x1f6eda(_0x4129eb) & 65535) << 5) >>> 0;
      Memory.patchCode(_0x152f60, 4, _0x137ccf => _0x137ccf.writeU32(_0x1c7e57));
      let _0x11891b = _0x152f60.readU32();
      if (_0x11891b !== _0x1c7e57) {
        return "clamp site +0x" + _0x8ce830.delta.toString(16) + " did not take: wrote 0x" + _0x1c7e57.toString(16) + ", reads 0x" + _0x11891b.toString(16);
      }
      _0x3f9690.push("+0x" + _0x8ce830.delta.toString(16) + "=0x" + _0x11891b.toString(16));
    }
    let _0x385db5 = _0x1beb5b(_0x50cd59.add(off2.zoomRadii).readPointer());
    if (_0x385db5.length < 3) {
      return "targetRadii is not the three floats this expects";
    }
    _0x8b4a0e = _0x35f262;
    let _0x2cf485 = _0x399dec();
    if (!_0x2cf485.isNull()) {
      _0x2cf485.add(off2.camRecenterTilt).writeU8(0);
      _0x2cf485.add(off2.camRecenterHeading).writeU8(0);
    }
    send({
      t: "cam",
      on: true,
      ceiling: _0x4129eb,
      topRadius: _0x35f262,
      sites: _0x3f9690,
      heights: _0x1beb5b(_0x50cd59.add(off2.zoomHeights).readPointer()),
      radii: _0x385db5
    });
    return null;
  }
  function _0x36afe3() {
    if (!_0x3aa646) {
      return "camera offsets not loaded";
    }
    let off2 = off;
    _0x8b4a0e = null;
    for (let _0x358002 in _0x33963e) {
      let _0x2c1e3e = _0x9ca124.add(off2.rvaZoomClamp + parseInt(_0x358002, 10));
      let _0x8a5c5a = _0x33963e[_0x358002];
      Memory.patchCode(_0x2c1e3e, 4, _0x372390 => _0x372390.writeU32(_0x8a5c5a));
    }
    _0x33963e = {};
    let _0x38c91c = _0x399dec();
    if (_0x42cbb7 !== null && !_0x38c91c.isNull()) {
      _0x38c91c.add(off2.camBindingMode).writeS32(_0x42cbb7.bind);
      _0x38c91c.add(off2.camHeading).writeS32(_0x42cbb7.heading);
      _0x38c91c.add(off2.camRecenterHeading).writeU8(_0x42cbb7.recH);
      _0x38c91c.add(off2.camRecenterTilt).writeU8(_0x42cbb7.recY);
    }
    send({
      t: "cam",
      on: false
    });
    return null;
  }
  function _0x42242d() {
    let off2 = off;
    let _0x1f623c = _0xa44dd5(off2, KEYS_ZOOM);
    if (_0x1f623c.length > 0) {
      _0x18794e = _0x1f623c;
      _0x46bd9a = "offsets missing";
      return false;
    }
    _0x18794e = [];
    _0x548284 = new _0x394686({
      identity() {
        return _0xc76a1(off2);
      },
      read() {
        if (_0xc76a1(off2) === null) {
          return null;
        } else {
          return {
            heights: _0x1beb5b(_0x50cd59.add(off2.zoomHeights).readPointer()),
            radii: _0x1beb5b(_0x50cd59.add(off2.zoomRadii).readPointer())
          };
        }
      },
      write(_0x1c0417) {
        if (_0xc76a1(off2) === null) {
          throw new Error("Zoom instance is no longer live");
        }
        let zoomHeightsPtr = _0x50cd59.add(off2.zoomHeights).readPointer();
        let zoomRadiiPtr = _0x50cd59.add(off2.zoomRadii).readPointer();
        if (zoomHeightsPtr.isNull() || zoomRadiiPtr.isNull()) {
          throw new Error("Camera zoom target array is unavailable");
        }
        let arrCount = zoomHeightsPtr.add(off2.arrCount).readU32();
        let arrCount2 = zoomRadiiPtr.add(off2.arrCount).readU32();
        if (arrCount < 3 || arrCount2 < 3) {
          throw new Error("Camera zoom target array contains fewer than three values");
        }
        let _0x38ea4b = _0x1c0417.radii.slice();
        if (_0x8b4a0e !== null) {
          _0x38ea4b[0] = _0x8b4a0e;
        }
        _0x4437c7(zoomHeightsPtr, _0x1c0417.heights);
        _0x4437c7(zoomRadiiPtr, _0x38ea4b);
        return {
          heights: _0x1c0417.heights,
          radii: _0x38ea4b
        };
      }
    });
    let _0x63f942 = Process.findModuleByName(off2.module);
    if (_0x63f942 === null || !_0x63f942.base.equals(_0x9ca124)) {
      _0x46bd9a = "camera module is unavailable";
      return false;
    }
    let _0x2f0851;
    try {
      _0x2f0851 = _0x137ef3(_0x63f942);
    } catch (_0x148fe9) {
      _0x46bd9a = "camera ELF validation failed: " + _0x148fe9;
      return false;
    }
    let _0x78685f = _0x2e0bba(_0x63f942, _0x2f0851, off2.rvaZoomUpdate, "Zoom.Update");
    let _0x521285 = _0x2e0bba(_0x63f942, _0x2f0851, off2.rvaZoomLateUpdate, "Zoom.LateUpdate");
    if (typeof _0x78685f == "string") {
      _0x46bd9a = _0x78685f;
      return false;
    }
    if (typeof _0x521285 == "string") {
      _0x46bd9a = _0x521285;
      return false;
    }
    try {
      _0x2d510a(_0x78685f);
      _0x23e827(_0x521285);
    } catch (_0x484abf) {
      _0x46bd9a = "camera hook installation failed: " + _0x484abf;
      return false;
    }
    _0x46bd9a = "";
    return true;
  }
  function _0x2d510a(_0x2ecf67) {
    if (_0xcbf549 !== null && _0x3a4dc3.equals(_0x2ecf67)) {
      return;
    }
    if (_0xcbf549 !== null) {
      try {
        _0xcbf549.detach();
      } catch {}
      _0xcbf549 = null;
      _0x3a4dc3 = NULL;
    }
    _0xcbf549 = Interceptor.attach(_0x2ecf67, {
      onEnter(args) {
        if (!_0x3aa646 || off === null) {
          return;
        }
        let off2 = off;
        _0x50cd59 = args[0];
        _0x4856fe = Date.now();
        if (_0x369dae) {
          return;
        }
        _0x369dae = true;
        let _0x1ca811 = _0x399dec();
        if (!_0x1ca811.isNull()) {
          _0x42cbb7 = {
            bind: _0x1ca811.add(off2.camBindingMode).readS32(),
            heading: _0x1ca811.add(off2.camHeading).readS32(),
            recH: _0x1ca811.add(off2.camRecenterHeading).readU8(),
            recY: _0x1ca811.add(off2.camRecenterTilt).readU8()
          };
        }
      }
    });
    _0x3a4dc3 = _0x2ecf67;
  }
  function _0x23e827(_0x3bdfab) {
    if (_0x304e93 !== null && _0x2779b0.equals(_0x3bdfab)) {
      return;
    }
    if (_0x304e93 !== null) {
      try {
        _0x304e93.detach();
      } catch {}
      _0x304e93 = null;
      _0x2779b0 = NULL;
    }
    _0x304e93 = Interceptor.attach(_0x3bdfab, {
      onEnter(args) {
        this.self = args[0];
        if (_0x3aa646) {
          _0x50cd59 = args[0];
          _0x4856fe = Date.now();
        }
      },
      onLeave() {
        let _0x375023 = this.self;
        _0x36e75c(_0x375023);
        if (!_0x3aa646 || off === null) {
          return;
        }
        if (_0x548284 !== null) {
          for (let _0x2f5d26 of _0x548284.frame(Date.now())) {
            send(_0x2f5d26);
          }
        }
        if (_0x8b4a0e === null || _0x375023 === undefined || _0x375023.isNull()) {
          return;
        }
        let off2 = off;
        _0x4437c7(_0x375023.add(off2.zoomRadii).readPointer(), [_0x8b4a0e]);
      }
    });
    _0x2779b0 = _0x3bdfab;
  }
  function _0x225927() {
    if (_0x304e93 !== null) {
      try {
        _0x304e93.detach();
      } catch {}
      _0x304e93 = null;
    }
    if (_0xcbf549 !== null) {
      try {
        _0xcbf549.detach();
      } catch {}
      _0xcbf549 = null;
    }
    _0x2779b0 = NULL;
    _0x3a4dc3 = NULL;
  }
  function _0xc76a1(off2) {
    if (_0x50cd59.isNull() || _0x4856fe <= 0 || Date.now() - _0x4856fe > _0x2fabd3) {
      return null;
    }
    try {
      if (_0x50cd59.add(off2.objCachedPtr).readPointer().isNull()) {
        return null;
      } else {
        return _0x50cd59.toString();
      }
    } catch {
      return null;
    }
  }
  function _0x399dec() {
    let off2 = off;
    if (off2 === null || !off2.zoomCineCam || _0x50cd59.isNull()) {
      return NULL;
    } else {
      return _0x50cd59.add(off2.zoomCineCam).readPointer();
    }
  }
  function _0x1beb5b(_0x2e631f) {
    let off2 = off;
    let _0x1c502a = [];
    if (_0x2e631f.isNull()) {
      return _0x1c502a;
    }
    let arrCount = _0x2e631f.add(off2.arrCount).readU32();
    for (let _0x4a20ac = 0; _0x4a20ac < Math.min(arrCount, 3); _0x4a20ac++) {
      _0x1c502a.push(_0x2e631f.add(off2.arrFirst + _0x4a20ac * 4).readFloat());
    }
    return _0x1c502a;
  }
  function _0x4437c7(_0xca3dfa, _0x44bbfb) {
    let off2 = off;
    if (_0xca3dfa.isNull()) {
      return;
    }
    let arrCount = _0xca3dfa.add(off2.arrCount).readU32();
    for (let _0x4befe2 = 0; _0x4befe2 < Math.min(arrCount, _0x44bbfb.length, 3); _0x4befe2++) {
      _0xca3dfa.add(off2.arrFirst + _0x4befe2 * 4).writeFloat(_0x44bbfb[_0x4befe2]);
    }
  }
  function _0x2c71d4(_0x500858) {
    _0x25cf34 = false;
    _0x2a51b7 = false;
    _0x35f8bb = [];
    _0x294766 = _0x500858;
    _0x481397 = 0;
    _0x2b50d5 = 0;
    _0x40063d = NULL;
    _0x82659a = null;
    _0x58d068 = null;
    _0x505f89 = null;
    if (_0x481f5c !== null) {
      clearTimeout(_0x481f5c);
      _0x481f5c = null;
    }
    _0x8df09b = false;
    _0x4dcfb5 = [];
    _0x3a671a?.forget();
    _0x3a671a = null;
  }
  function _0x36e75c(_0x4ca200) {
    if (_0x3a671a !== null) {
      _0x481397++;
      if (_0x8df09b) {
        _0x3a671a.release();
        _0x8df09b = false;
        setImmediate(_0x3b1c6d);
        return;
      }
      if (!!_0x25cf34 && _0x4ca200 !== undefined && !_0x4ca200.isNull()) {
        _0x3a671a.frame(_0x4ca200.toString(), Date.now());
      }
    }
  }
  function _0x3b1c6d() {
    if (_0x481f5c !== null) {
      clearTimeout(_0x481f5c);
      _0x481f5c = null;
    }
    let _0x379c7c = _0x4dcfb5;
    _0x4dcfb5 = [];
    for (let _0x811dce of _0x379c7c) {
      try {
        _0x811dce();
      } catch (_0x3cd84a) {
        send({
          t: "fog_release_error",
          error: "" + _0x3cd84a
        });
      }
    }
  }
  function _0x44ec3a(_0x4a84bf) {
    _0x25cf34 = false;
    if (_0x3a671a === null || !_0x3a671a.hasOwner()) {
      _0x3a671a?.forget();
      _0x4a84bf();
      return;
    }
    _0x4dcfb5.push(_0x4a84bf);
    if (!_0x8df09b) {
      _0x8df09b = true;
      _0x481f5c = setTimeout(() => {
        if (_0x8df09b) {
          _0x8df09b = false;
          _0x3a671a?.forget();
          _0x3b1c6d();
        }
      }, 1000);
    }
  }
  function _0x130f2f(_0x220377) {
    _0x3ba549();
    _0x5923fc.request(_0x220377, () => _0x3a671a !== null && _0x3a671a.hasOwner(), _0x1ea84f => _0x44ec3a(_0x1ea84f), _0x339a59 => {
      if (_0x3a671a !== null || _0x304e93 !== null) {
        _0x2c71d4("offset table replaced");
      }
      _0x14acb5(_0x339a59);
    });
  }
  function _0x3dedea() {
    let off2 = off;
    let _0x13a91a = _0xa44dd5(off2, KEYS_FOG);
    if (_0x13a91a.length > 0) {
      _0x35f8bb = _0x13a91a;
      _0x294766 = "offsets missing";
      return false;
    }
    _0x35f8bb = [];
    let _0x589cda = Process.findModuleByName("libunity.so");
    if (_0x589cda === null) {
      _0x294766 = "libunity.so is not loaded";
      return false;
    }
    let _0x4ae34b;
    try {
      _0x4ae34b = _0x137ef3(_0x589cda);
    } catch (_0x29fc06) {
      _0x294766 = "native fog ELF validation failed: " + _0x29fc06;
      return false;
    }
    let _0x2af143 = _0x2e0bba(_0x589cda, _0x4ae34b, off2.rvaFogSettings, "RenderSettings accessor");
    let _0x22b165 = _0x2e0bba(_0x589cda, _0x4ae34b, off2.rvaFogGet, "RenderSettings.get_fog");
    let _0x390a53 = _0x2e0bba(_0x589cda, _0x4ae34b, off2.rvaFogSet, "RenderSettings.set_fog");
    for (let _0x3d94ca of [_0x2af143, _0x22b165, _0x390a53]) {
      if (typeof _0x3d94ca == "string") {
        _0x294766 = _0x3d94ca;
        return false;
      }
    }
    let _0x531bbc = Process.findModuleByName(off2.module);
    if (_0x531bbc === null || !_0x531bbc.base.equals(_0x9ca124)) {
      _0x294766 = "fog camera anchor module is unavailable";
      return false;
    }
    let _0x1a009e;
    try {
      _0x1a009e = _0x137ef3(_0x531bbc);
    } catch (_0x102e02) {
      _0x294766 = "fog camera anchor ELF validation failed: " + _0x102e02;
      return false;
    }
    let _0x120e9 = _0x2e0bba(_0x531bbc, _0x1a009e, off2.rvaZoomLateUpdate, "Zoom.LateUpdate fog anchor");
    if (typeof _0x120e9 == "string") {
      _0x294766 = _0x120e9;
      return false;
    }
    let _0x425ce6 = null;
    let _0x264b9e = -1;
    for (let _0x3a9b01 = 0; _0x3a9b01 < 24; _0x3a9b01 += 4) {
      let _0x5be8bb = _0x22b165.add(_0x3a9b01);
      let _0x20e32e = _0x5be8bb.readU32();
      let _0x1942fd = _0x1634af(_0x5be8bb, _0x20e32e);
      if (_0x1942fd !== null && _0x425ce6 === null) {
        _0x425ce6 = _0x1942fd;
      }
      if ((_0x20e32e & 4290774015) >>> 0 === 960495616) {
        _0x264b9e = _0x20e32e >>> 10 & 4095;
      }
    }
    let _0x3ca40a = _0x390a53.readU32();
    let _0x55d11b = _0x390a53.add(4).readU32();
    let _0x6e6b00 = _0x4c14a7(_0x390a53.add(4), _0x55d11b);
    let _0x48541b = _0x264b9e < 0 ? -1 : (_0x264b9e << 10 | 956301313) >>> 0;
    if (_0x425ce6 === null || !_0x425ce6.equals(_0x2af143) || _0x264b9e < 0 || _0x3ca40a !== _0x48541b || _0x6e6b00 === null || !_0x109b56(_0x6e6b00, _0x4ae34b)) {
      _0x294766 = "native fog ARM64 signature does not match the scanner contract";
      return false;
    }
    _0x82659a = new NativeFunction(_0x2af143, "pointer", []);
    _0x58d068 = new NativeFunction(_0x22b165, "int", []);
    _0x505f89 = new NativeFunction(_0x390a53, "void", ["pointer", "int"]);
    _0x3a671a = new _0x11ee19({
      identity(_0x14677c) {
        try {
          let _0x2638e8 = ptr(_0x14677c);
          if (_0x2638e8.isNull() || _0x2638e8.add(off2.objCachedPtr).readPointer().isNull()) {
            return null;
          }
          let _0x1ea4d = _0x82659a();
          if (_0x1ea4d.isNull()) {
            return null;
          } else {
            _0x40063d = _0x1ea4d;
            return {
              owner: _0x2638e8.toString() + ":" + _0x1ea4d.toString(),
              scene: _0x1ea4d.toString()
            };
          }
        } catch {
          return null;
        }
      },
      read() {
        let _0x54b45f = _0x58d068();
        if (_0x54b45f !== 0 && _0x54b45f !== 1) {
          throw new Error("RenderSettings.get_fog returned a non-boolean value");
        }
        return _0x54b45f === 1;
      },
      write(_0x126e74) {
        if (_0x40063d.isNull()) {
          throw new Error("RenderSettings owner is unavailable");
        }
        _0x505f89(_0x40063d, _0x126e74 ? 1 : 0);
        _0x2b50d5++;
      }
    });
    try {
      _0x23e827(_0x120e9);
    } catch (_0x5a9b68) {
      _0x3a671a = null;
      _0x294766 = "fog camera hook installation failed: " + _0x5a9b68;
      return false;
    }
    _0x294766 = "";
    _0x25cf34 = true;
    return true;
  }
  function _0x1f6eda(_0x4be0ae) {
    let _0x2b1e7f = Memory.alloc(4);
    _0x2b1e7f.writeFloat(_0x4be0ae);
    return _0x2b1e7f.readU32() >>> 16;
  }
  function _0x3fda91() {
    let _0x54a2ba = off;
    return [{
      delta: _0x54a2ba.camDeltaHeight0,
      was: _0x54a2ba.camWasHeight0,
      what: "targetHeights[0]"
    }, {
      delta: _0x54a2ba.camDeltaRadius0,
      was: _0x54a2ba.camWasRadius0,
      what: "targetRadii[0] + targetHeights[1]"
    }, {
      delta: _0x54a2ba.camDeltaRadius1,
      was: _0x54a2ba.camWasRadius1,
      what: "targetRadii[1]"
    }, {
      delta: _0x54a2ba.camDeltaRadius2,
      was: _0x54a2ba.camWasRadius2,
      what: "targetRadii[2]"
    }];
  }
  function _0x2fba74(_0x58a91d, _0x7bef0) {
    if ((_0x58a91d & 4292870144) >>> 0 !== 1386217472) {
      return false;
    } else {
      return (_0x58a91d >>> 5 & 65535) === _0x1f6eda(_0x7bef0);
    }
  }
  function _0x160529() {
    let off2 = off;
    let _0x273aba = _0xa44dd5(off2, KEYS_QUICKSLOT);
    if (_0x273aba.length > 0) {
      _0x4af91f = _0x273aba;
      _0x5aa6c0 = "offsets missing";
      return false;
    }
    _0x4af91f = [];
    let _0x24a566 = [{
      rva: off2.rvaSlotAnchor,
      what: "ConsumableQuickSlotData.FixedUpdate"
    }, {
      rva: off2.rvaSlotContainer,
      what: "ConsumableQuickSlotData.get_Container"
    }, {
      rva: off2.rvaSlotGetSlots,
      what: "InventoryObject.get_GetSlots"
    }, {
      rva: off2.rvaSlotUse,
      what: "ConsumableQuickSlotData.UseSlot"
    }];
    for (let _0x1570b9 of _0x24a566) {
      let _0x4aed54 = _0x3166d6(_0x1570b9.rva, _0x1570b9.what);
      if (typeof _0x4aed54 == "string") {
        _0x5aa6c0 = _0x4aed54;
        return false;
      }
    }
    _0xafd509 = new NativeFunction(_0x9ca124.add(off2.rvaSlotContainer), "pointer", ["pointer"]);
    _0x256353 = new NativeFunction(_0x9ca124.add(off2.rvaSlotGetSlots), "pointer", ["pointer", "pointer"]);
    _0xc2356e = new NativeFunction(_0x9ca124.add(off2.rvaSlotUse), "void", ["pointer", "pointer", "pointer"]);
    Interceptor.attach(_0x9ca124.add(off2.rvaSlotAnchor), {
      onEnter(args) {
        _0x38ac97 = args[0];
      }
    });
    _0x5aa6c0 = "";
    return true;
  }
  function _0x18ac83(_0x582170) {
    if (!_0x120c62) {
      send({
        t: "slot",
        ok: false,
        use: _0x582170,
        error: "quick slot offsets not loaded"
      });
      return;
    }
    let off2 = off;
    if (_0x582170 < 1 || _0x582170 > off2.slotMax) {
      send({
        t: "slot",
        ok: false,
        use: _0x582170,
        error: "slot " + _0x582170 + " is outside 1.." + off2.slotMax
      });
      return;
    }
    if (_0x38ac97.isNull()) {
      send({
        t: "slot",
        ok: false,
        use: _0x582170,
        error: "no quick slot manager yet"
      });
      return;
    }
    if (!_0x5b8db7(() => {
      try {
        let _0x5a3ccd = _0xafd509(NULL);
        if (_0x5a3ccd.isNull()) {
          send({
            t: "slot",
            ok: false,
            use: _0x582170,
            error: "no inventory container"
          });
          return;
        }
        let _0x4a4e6a = _0x256353(_0x5a3ccd, NULL);
        if (_0x4a4e6a.isNull()) {
          send({
            t: "slot",
            ok: false,
            use: _0x582170,
            error: "no slot array"
          });
          return;
        }
        let arrCount = _0x4a4e6a.add(off2.arrCount).readU32();
        let _0x2183b0 = _0x582170 - 1;
        if (_0x2183b0 >= arrCount) {
          send({
            t: "slot",
            ok: false,
            use: _0x582170,
            error: "slot " + _0x582170 + " is past the end: the bar holds " + arrCount
          });
          return;
        }
        let _0x3a87af = _0x4a4e6a.add(off2.arrFirst + _0x2183b0 * off2.arrStride).readPointer();
        if (_0x3a87af.isNull()) {
          send({
            t: "slot",
            ok: false,
            use: _0x582170,
            error: "slot " + _0x582170 + " is empty"
          });
          return;
        }
        if (_0x3a87af.add(off2.slotItem).readPointer().isNull()) {
          send({
            t: "slot",
            ok: false,
            use: _0x582170,
            error: "slot " + _0x582170 + " is empty"
          });
          return;
        }
        let slotAmount = _0x3a87af.add(off2.slotAmount).readS32();
        _0xc2356e(_0x38ac97, _0x3a87af, NULL);
        send({
          t: "slot",
          ok: true,
          use: _0x582170,
          amount: slotAmount
        });
      } catch (_0x3f6b6d) {
        send({
          t: "slot",
          ok: false,
          use: _0x582170,
          error: "" + _0x3f6b6d
        });
      }
    })) {
      send({
        t: "slot",
        ok: false,
        use: _0x582170,
        error: "frame queue unavailable"
      });
    }
  }
  function _0x2f93a2() {
    let off2 = off;
    let _0x5c1329 = _0xa44dd5(off2, KEYS_ATTACK);
    if (_0x5c1329.length > 0) {
      _0x561396 = _0x5c1329;
      _0xcf39b4 = "offsets missing";
      return false;
    }
    _0x561396 = [];
    let _0x3c0fd7 = [{
      rva: off2.rvaAtkAnchor,
      what: "PlayerEnemyClicker.FixedUpdate"
    }, {
      rva: off2.rvaAtkSetTarget,
      what: "PlayerEnemyClicker.SetTarget"
    }, {
      rva: off2.rvaAtkSetEnemy,
      what: "PlayerFollowToAttack.SetEnemy"
    }, {
      rva: off2.rvaAtkPress,
      what: "PlayerFollowToAttack.OnButtonPress"
    }, {
      rva: off2.rvaAtkCancel,
      what: "PlayerFollowToAttack.CancelAttack"
    }, {
      rva: off2.rvaAtkGetCrow,
      what: "PlayerHandler.GetCrow"
    }, {
      rva: off2.rvaComponentGetGameObject,
      what: "Component.get_gameObject"
    }];
    for (let _0x20c2e6 of _0x3c0fd7) {
      let _0x2ec9e9 = _0x3166d6(_0x20c2e6.rva, _0x20c2e6.what);
      if (typeof _0x2ec9e9 == "string") {
        _0xcf39b4 = _0x2ec9e9;
        return false;
      }
    }
    _0x3493d7 = new NativeFunction(_0x9ca124.add(off2.rvaAtkGetCrow), "pointer", ["pointer", "uint16", "pointer"]);
    _0x8b33cc = new NativeFunction(_0x9ca124.add(off2.rvaComponentGetGameObject), "pointer", ["pointer", "pointer"]);
    _0x5a3803 = new NativeFunction(_0x9ca124.add(off2.rvaAtkSetTarget), "void", ["pointer", "pointer", "int", "pointer"]);
    _0xdefa3c = new NativeFunction(_0x9ca124.add(off2.rvaAtkSetEnemy), "void", ["pointer", "int", "pointer", "pointer"]);
    _0x53e867 = new NativeFunction(_0x9ca124.add(off2.rvaAtkPress), "int", ["pointer", "pointer"]);
    _0x3b52d3 = new NativeFunction(_0x9ca124.add(off2.rvaAtkCancel), "void", ["pointer", "pointer"]);
    _0x329721();
    _0x5e293d = Interceptor.attach(_0x9ca124.add(off2.rvaAtkAnchor), {
      onEnter(args) {
        _0x16d9be = args[0];
      }
    });
    _0xcf39b4 = "";
    return true;
  }
  function _0x329721() {
    if (_0x5e293d !== null) {
      _0x5e293d.detach();
      _0x5e293d = null;
    }
  }
  function _0x328e9b(_0x5a0930, _0x2a321e) {
    let off2 = off;
    let ecPftaPtr = _0x16d9be.add(off2.ecPfta).readPointer();
    if (ecPftaPtr.isNull()) {
      send(Object.assign({
        t: _0x5a0930,
        ok: false,
        error: "no follow-to-attack yet"
      }, _0x2a321e));
      return null;
    } else {
      return ecPftaPtr;
    }
  }
  function _0x202ef9(_0x480055, _0xf63619) {
    if (!_0x1ca03c) {
      send({
        t: "attack",
        ok: false,
        id: _0x480055,
        error: "attack offsets not loaded"
      });
      return;
    }
    let off2 = off;
    if (!(_0x480055 >= 0) || !(_0x480055 <= off2.crowIdMax)) {
      send({
        t: "attack",
        ok: false,
        id: _0x480055,
        error: "crow id " + _0x480055 + " is outside 0.." + off2.crowIdMax
      });
      return;
    }
    if (_0x298ea0.isNull()) {
      send({
        t: "attack",
        ok: false,
        id: _0x480055,
        error: "no player handler yet"
      });
      return;
    }
    if (_0x16d9be.isNull()) {
      send({
        t: "attack",
        ok: false,
        id: _0x480055,
        error: "no enemy clicker yet"
      });
      return;
    }
    if (!_0x5b8db7(() => {
      try {
        let _0x235d39 = _0x328e9b("attack", {
          id: _0x480055
        });
        if (_0x235d39 === null) {
          return;
        }
        let _0x458861 = _0x3493d7(_0x298ea0, _0x480055, NULL);
        if (_0x458861.isNull()) {
          send({
            t: "attack",
            ok: false,
            id: _0x480055,
            error: "crow " + _0x480055 + " is not in the array"
          });
          return;
        }
        let _0x5a13ca = _0x8b33cc(_0x458861, NULL);
        if (_0x5a13ca.isNull()) {
          send({
            t: "attack",
            ok: false,
            id: _0x480055,
            error: "crow " + _0x480055 + " has no game object"
          });
          return;
        }
        _0x5a3803(_0x16d9be, _0x5a13ca, off2.crowMob, NULL);
        _0xdefa3c(_0x235d39, off2.crowMob, _0x5a13ca, NULL);
        let _0x342c7e = _0xf63619 ? _0x53e867(_0x235d39, NULL) : -1;
        send({
          t: "attack",
          ok: true,
          id: _0x480055,
          code: _0x342c7e,
          pressed: _0xf63619
        });
      } catch (_0x53a3fe) {
        send({
          t: "attack",
          ok: false,
          id: _0x480055,
          error: "" + _0x53a3fe
        });
      }
    })) {
      send({
        t: "attack",
        ok: false,
        id: _0x480055,
        error: "frame queue unavailable"
      });
    }
  }
  function _0x32c20a() {
    if (!_0x1ca03c) {
      send({
        t: "attack_stop",
        ok: false,
        error: "attack offsets not loaded"
      });
      return;
    }
    if (_0x16d9be.isNull()) {
      send({
        t: "attack_stop",
        ok: false,
        error: "no enemy clicker yet"
      });
      return;
    }
    if (!_0x5b8db7(() => {
      try {
        let _0x1d9c73 = _0x328e9b("attack_stop", {});
        if (_0x1d9c73 === null) {
          return;
        }
        _0x3b52d3(_0x1d9c73, NULL);
        send({
          t: "attack_stop",
          ok: true
        });
      } catch (_0x370a20) {
        send({
          t: "attack_stop",
          ok: false,
          error: "" + _0x370a20
        });
      }
    })) {
      send({
        t: "attack_stop",
        ok: false,
        error: "frame queue unavailable"
      });
    }
  }
  function _0x5c5ec5(_0x204a51) {
    let _0x5147f7 = _0x3166d6(_0x204a51, "ServerConnectionManager.Update");
    if (typeof _0x5147f7 == "string") {
      return _0x5147f7;
    } else {
      if (_0x5a9ced === null) {
        _0x5a9ced = Interceptor.attach(_0x5147f7, {
          onEnter(args) {
            _0x53c8d0 = args[0];
          }
        });
      }
      return null;
    }
  }
  function _0x2141aa() {
    let off2 = off;
    let _0x1ec54e = _0xa44dd5(off2, KEYS_SCENE_LOADER);
    if (_0x1ec54e.length > 0) {
      _0x2ea383 = _0x1ec54e;
      _0x3821d4 = "offsets missing";
      return false;
    }
    _0x2ea383 = [];
    let _0x5c9515 = _0x524517(off2.tiMultiSceneHelper, "MultiSceneHelper.TypeInfo");
    if (_0x5c9515 !== null) {
      _0x3821d4 = _0x5c9515;
      return false;
    }
    let _0x58c468 = _0x3166d6(off2.rvaBehaviourGetEnabled, "Behaviour.get_enabled");
    if (typeof _0x58c468 == "string") {
      _0x3821d4 = _0x58c468;
      return false;
    } else {
      _0x3be0a9 = new NativeFunction(_0x58c468, "bool", ["pointer", "pointer"]);
      _0x3821d4 = "";
      return true;
    }
  }
  function _0x4f7614() {
    let off2 = off;
    let _0xdfefb3 = _0xa44dd5(off2, KEYS_REBIRTH);
    if (_0xdfefb3.length > 0) {
      _0x598183 = _0xdfefb3;
      _0xa669d5 = "offsets missing";
      return false;
    }
    _0x598183 = [];
    let _0x196d0b = _0x524517(off2.tiInstanceContainer, "InstanceContainer.TypeInfo");
    if (_0x196d0b !== null) {
      _0xa669d5 = _0x196d0b;
      return false;
    }
    let _0x1aed93 = [{
      rva: off2.rvaIsGenuinelyDead,
      what: "PlayerModal.IsGenuinelyDead"
    }, {
      rva: off2.rvaLandIsTyranny,
      what: "ServerConnectionManager.get_LandIsTyranny"
    }, {
      rva: off2.rvaIsConfronting,
      what: "ServerConnectionManager.get_IsConfronting"
    }, {
      rva: off2.rvaIsInPostConfrontGrace,
      what: "ServerConnectionManager.get_IsInPostConfrontGrace"
    }, {
      rva: off2.rvaSendRebirth,
      what: "ServerConnectionManager.SendRebirthRequest"
    }, {
      rva: off2.rvaHasValidRosary,
      what: "InventoryObject.HasValidRosary"
    }];
    for (let _0x5a90eb of _0x1aed93) {
      let _0x23faf8 = _0x3166d6(_0x5a90eb.rva, _0x5a90eb.what);
      if (typeof _0x23faf8 == "string") {
        _0xa669d5 = _0x23faf8;
        return false;
      }
    }
    let _0xd4592 = _0x5c5ec5(off2.rvaPickAnchor);
    if (_0xd4592 !== null) {
      _0xa669d5 = _0xd4592;
      return false;
    } else {
      _0x441c68 = new NativeFunction(_0x9ca124.add(off2.rvaIsGenuinelyDead), "bool", ["pointer", "pointer"]);
      _0x52cd94 = new NativeFunction(_0x9ca124.add(off2.rvaLandIsTyranny), "bool", ["pointer", "pointer"]);
      _0x27c34b = new NativeFunction(_0x9ca124.add(off2.rvaIsConfronting), "bool", ["pointer", "pointer"]);
      _0x2dbd2e = new NativeFunction(_0x9ca124.add(off2.rvaIsInPostConfrontGrace), "bool", ["pointer", "pointer"]);
      _0x41bf4e = new NativeFunction(_0x9ca124.add(off2.rvaSendRebirth), "void", ["pointer", "bool", "pointer"]);
      _0x4f68f0 = new NativeFunction(_0x9ca124.add(off2.rvaHasValidRosary), "bool", ["pointer", "pointer"]);
      _0xa669d5 = "";
      return true;
    }
  }
  function _0x426466() {
    let off2 = off;
    let _0x501e20 = _0xa44dd5(off2, KEYS_CLIENT);
    if (_0x501e20.length > 0) {
      _0x392a93 = _0x501e20;
      _0x1293d9 = "offsets missing";
      return false;
    }
    _0x392a93 = [];
    let _0x339eca = _0x524517(off2.tiClient, "Client TypeInfo");
    if (_0x339eca !== null) {
      _0x1293d9 = _0x339eca;
      return false;
    } else {
      _0x1293d9 = "";
      return true;
    }
  }
  function _0xedbb7e() {
    let _0x1baf2c = off;
    if (_0x1baf2c === null || !_0x4fbebf) {
      return _0xab855f.value;
    }
    try {
      let off2 = _0x1baf2c;
      let _0x3f6a19 = _0x35e499(off2.tiClient, off2.sfClientInstance);
      if (!_0x3f6a19.isNull()) {
        _0xab855f.observe(_0x2df1c6(_0x3f6a19, off2.clientUserId));
      }
    } catch {}
    return _0xab855f.value;
  }
  function _0x180e35(_0xc748d0, _0x1ac5fb, _0x4cc1a3, _0x140416) {
    if (_0x176816.complete(_0xc748d0)) {
      send({
        t: "rebirth",
        ok: _0x1ac5fb,
        req: _0xc748d0.req,
        mode: _0xc748d0.mode,
        useRosary: _0x4cc1a3,
        confirmed: false,
        error: _0x140416
      });
    }
  }
  function _0x5e729e(_0x3538b4) {
    let _0x4eec10 = _0x176816.expire(_0x3538b4, Date.now());
    if (_0x4eec10 !== null) {
      _0x3980f1 = null;
      _0x180e35(_0x4eec10, false, null, "watchdog expired");
    }
  }
  function _0x45cdfd(_0x29e909, _0x3b7d94) {
    let _0x59ff42 = _0x176816.ask(_0x29e909, _0x3b7d94, Date.now(), _0x1a3467, _0x3845a7);
    if (_0x59ff42.error !== null) {
      _0x180e35(_0x59ff42.job, false, null, _0x59ff42.error);
      return;
    }
    let _0x227188 = _0x59ff42.job.generation;
    _0x3980f1 = setTimeout(() => _0x5e729e(_0x227188), _0x1a3467);
  }
  function _0x394146() {
    let _0x3b70a8 = _0x176816.take(Date.now());
    if (_0x3b70a8 === null) {
      return;
    }
    let _0x1cb90d = _0x3b70a8.job;
    if (_0x3b70a8.error !== null) {
      if (_0x3980f1 !== null) {
        clearTimeout(_0x3980f1);
        _0x3980f1 = null;
      }
      _0x180e35(_0x1cb90d, false, null, _0x3b70a8.error);
      return;
    }
    if (_0x3980f1 !== null) {
      clearTimeout(_0x3980f1);
      _0x3980f1 = null;
    }
    try {
      let off2 = off;
      let _0x5a2121 = _0x53c8d0;
      let _0x4069a7 = _0x5a2121.isNull() ? NULL : _0x5a2121.add(off2.scmZoneConnection).readPointer();
      let _0x3dc5a9 = _0x43f6d8(!_0x5a2121.isNull(), !_0x4069a7.isNull());
      if (_0x3dc5a9 !== null) {
        _0x180e35(_0x1cb90d, false, null, _0x3dc5a9);
        return;
      }
      let _0x42ea6e = _0x390ac2;
      let _0x556bfc = _0x1efe5e(!_0x42ea6e.isNull() && _0x441c68(_0x42ea6e, NULL) !== 0, _0x52cd94(_0x5a2121, NULL) !== 0, _0x27c34b(_0x5a2121, NULL) !== 0, _0x2dbd2e(_0x5a2121, NULL) !== 0);
      if (_0x556bfc !== null) {
        _0x180e35(_0x1cb90d, false, null, _0x556bfc);
        return;
      }
      let _0x4fc2bd = NULL;
      if (_0x1cb90d.mode !== "normal") {
        let _0x3cc4b5 = _0x35e499(off2.tiInstanceContainer, off2.icInstance);
        _0x4fc2bd = _0x3cc4b5.isNull() ? NULL : _0x3cc4b5.add(off2.icEquipment).readPointer();
      }
      let _0x4b6b93 = _0x40e0ce(_0x1cb90d.mode, !_0x4fc2bd.isNull(), () => _0x4f68f0(_0x4fc2bd, NULL) !== 0);
      if (!_0x4b6b93.ok) {
        _0x180e35(_0x1cb90d, false, _0x4b6b93.useRosary, _0x4b6b93.error);
        return;
      }
      _0x41bf4e(_0x5a2121, _0x4b6b93.useRosary ? 1 : 0, NULL);
      _0x180e35(_0x1cb90d, true, _0x4b6b93.useRosary, "");
    } catch (_0x1c72e0) {
      _0x180e35(_0x1cb90d, false, null, "" + _0x1c72e0);
    }
  }
  function _0x46f24a() {
    let off2 = off;
    let _0x5c467f = _0xa44dd5(off2, KEYS_PICKUP);
    if (_0x5c467f.length > 0) {
      _0x51bb09 = _0x5c467f;
      _0x511771 = "offsets missing";
      return false;
    }
    _0x51bb09 = [];
    let _0x33303d = [{
      rva: off2.rvaPickAnchor,
      what: "ServerConnectionManager.Update"
    }, {
      rva: off2.rvaPickSend,
      what: "ServerConnectionManager.SendFieldPickupRequest"
    }];
    for (let _0x4c7b0b of _0x33303d) {
      let _0x420d8d = _0x3166d6(_0x4c7b0b.rva, _0x4c7b0b.what);
      if (typeof _0x420d8d == "string") {
        _0x511771 = _0x420d8d;
        return false;
      }
    }
    _0x1e0539 = new NativeFunction(_0x9ca124.add(off2.rvaPickSend), "void", ["pointer", "int", "uint16", "pointer"]);
    let _0x405640 = _0x5c5ec5(off2.rvaPickAnchor);
    if (_0x405640 !== null) {
      _0x511771 = _0x405640;
      return false;
    } else {
      _0x511771 = "";
      return true;
    }
  }
  function _0x20d6eb() {
    if (_0x5a9ced !== null) {
      _0x5a9ced.detach();
      _0x5a9ced = null;
    }
  }
  function _0x31fef9(_0x29ab7f, _0x2e715a, _0xf7237f) {
    if (!_0x210b66) {
      send({
        t: "pick",
        ok: false,
        id: _0x2e715a,
        type: _0x29ab7f,
        req: _0xf7237f,
        error: "pick offsets not loaded"
      });
      return;
    }
    let off2 = off;
    if (_0x29ab7f !== off2.crowItem && _0x29ab7f !== off2.crowMoney) {
      send({
        t: "pick",
        ok: false,
        id: _0x2e715a,
        type: _0x29ab7f,
        req: _0xf7237f,
        error: "crow type " + _0x29ab7f + " is neither " + off2.crowItem + " nor " + off2.crowMoney
      });
      return;
    }
    if (!(_0x2e715a > 0) || !(_0x2e715a <= 65535)) {
      send({
        t: "pick",
        ok: false,
        id: _0x2e715a,
        type: _0x29ab7f,
        req: _0xf7237f,
        error: "drop id " + _0x2e715a + " is outside 1..65535"
      });
      return;
    }
    if (_0x53c8d0.isNull()) {
      send({
        t: "pick",
        ok: false,
        id: _0x2e715a,
        type: _0x29ab7f,
        req: _0xf7237f,
        error: "no connection yet"
      });
      return;
    }
    if (!_0x5b8db7(() => {
      try {
        _0x1e0539(_0x53c8d0, _0x29ab7f, _0x2e715a, NULL);
        send({
          t: "pick",
          ok: true,
          id: _0x2e715a,
          type: _0x29ab7f,
          req: _0xf7237f
        });
      } catch (_0x51b901) {
        send({
          t: "pick",
          ok: false,
          id: _0x2e715a,
          type: _0x29ab7f,
          req: _0xf7237f,
          error: "" + _0x51b901
        });
      }
    })) {
      send({
        t: "pick",
        ok: false,
        id: _0x2e715a,
        type: _0x29ab7f,
        req: _0xf7237f,
        error: "frame queue unavailable"
      });
    }
  }
  function _0x3c303e() {
    let off2 = off;
    let _0x44c035 = _0xa44dd5(off2, KEYS_QBOX);
    if (_0x44c035.length > 0) {
      _0x4901c7 = _0x44c035;
      _0x3f3713 = "offsets missing";
      return false;
    }
    _0x4901c7 = [];
    let _0x763405 = _0x3166d6(off2.rvaGetComponentsInternal, "GameObject.GetComponentsInternal");
    if (typeof _0x763405 == "string") {
      _0x3f3713 = _0x763405;
      return false;
    }
    let _0x54cb3c = [{
      rva: off2.tiQBoxFunction,
      what: "QBoxFunction TypeInfo"
    }, {
      rva: off2.tiImage,
      what: "Image TypeInfo"
    }];
    for (let _0x2336c0 of _0x54cb3c) {
      let _0x45ba07 = _0x524517(_0x2336c0.rva, _0x2336c0.what);
      if (_0x45ba07 !== null) {
        _0x3f3713 = _0x45ba07;
        return false;
      }
    }
    let _0x24511e = Process.findModuleByName(off2.module);
    if (_0x24511e === null) {
      _0x3f3713 = "module not found: " + off2.module;
      return false;
    }
    let _0x2a7242 = _0x2f4e0c(_0x24511e, "il2cpp_class_get_type");
    if (_0x2a7242.isNull()) {
      _0x3f3713 = "il2cpp_class_get_type is not exported";
      return false;
    }
    let _0x455234 = _0x2f4e0c(_0x24511e, "il2cpp_type_get_object");
    if (_0x455234.isNull()) {
      _0x3f3713 = "il2cpp_type_get_object is not exported";
      return false;
    } else {
      _0x148505 = new NativeFunction(_0x763405, "pointer", ["pointer", "pointer", "uint8", "uint8", "uint8", "uint8", "pointer", "pointer"]);
      _0x552ea7 = new NativeFunction(_0x2a7242, "pointer", ["pointer"]);
      _0x171e7b = new NativeFunction(_0x455234, "pointer", ["pointer"]);
      _0x44b3ec = NULL;
      imgFillAmount = -1;
      _0x5b7018 = 0;
      _0x5f0b61 = 0;
      _0x3a3a4d = 0;
      _0x3f3713 = "";
      return true;
    }
  }
  function _0x3ed60a() {
    let _0x4f891a = {
      type: 0,
      total: 0,
      left: -1
    };
    let off2 = off;
    if (off2 == null || _0x390ac2.isNull()) {
      return _0x4f891a;
    }
    let pcCharLogicPtr = _0x390ac2.add(off2.pcCharLogic).readPointer();
    if (pcCharLogicPtr.isNull()) {
      return _0x4f891a;
    }
    let clQItemFactAddr = pcCharLogicPtr.add(off2.clQItemFact);
    let _0x1010ac = clQItemFactAddr.readU8();
    let qfTime = clQItemFactAddr.add(off2.qfTime).readFloat();
    if (_0x1010ac === 0) {
      return {
        type: _0x1010ac,
        total: qfTime,
        left: -1
      };
    }
    if (!_0x17a10c) {
      return {
        type: _0x1010ac,
        total: qfTime,
        left: -1
      };
    }
    let _0x519cf6 = Date.now();
    if ((_0x3a3a4d === 0 || !(_0x519cf6 - _0x3a3a4d < _0x338380)) && _0x5b8db7(() => _0x5adcba(_0x1010ac))) {
      _0x3a3a4d = _0x519cf6;
    }
    let _0x332b4e = _0x5b7018 === _0x1010ac && imgFillAmount >= 0 && _0x519cf6 - _0x5f0b61 < _0x338380;
    return {
      type: _0x1010ac,
      total: qfTime,
      left: _0x332b4e ? qfTime * imgFillAmount : -1
    };
  }
  function _0x5adcba(_0x4c9f0a) {
    _0x3a3a4d = 0;
    imgFillAmount = -1;
    _0x5b7018 = _0x4c9f0a;
    _0x5f0b61 = Date.now();
    if (!_0x17a10c || off === null) {
      return;
    }
    let off2 = off;
    let _0x10df6d = _0x35e499(off2.tiQBoxFunction, off2.sfQBoxInstance);
    if (_0x10df6d.isNull()) {
      return;
    }
    let qbIndicatorPtr = _0x10df6d.add(off2.qbIndicator).readPointer();
    if (qbIndicatorPtr.isNull() || qbIndicatorPtr.add(off2.objCachedPtr).readPointer().isNull()) {
      return;
    }
    let _0x49113b = _0x50a999(off2.tiImage);
    if (_0x49113b.isNull()) {
      return;
    }
    let _0x18920a = _0x148505(qbIndicatorPtr, _0x49113b, 1, 1, 0, 0, NULL, NULL);
    if (_0x18920a.isNull() || _0x18920a.add(off2.arrCount).readU32() <= _0x5c897b) {
      return;
    }
    let _0x36b957 = _0x18920a.add(off2.arrFirst + _0x5c897b * off2.arrStride).readPointer();
    if (!_0x36b957.isNull()) {
      imgFillAmount = _0x36b957.add(off2.imgFillAmount).readFloat();
    }
  }
  function _0x50a999(_0x15cf1b) {
    if (!_0x44b3ec.isNull()) {
      return _0x44b3ec;
    }
    let _0x161abd = _0x4588fc(_0x15cf1b);
    if (_0x161abd.isNull()) {
      return NULL;
    }
    let _0x10b3a6 = _0x552ea7(_0x161abd);
    if (_0x10b3a6.isNull()) {
      return NULL;
    } else {
      _0x44b3ec = _0x171e7b(_0x10b3a6);
      return _0x44b3ec;
    }
  }
  function _0x41f261() {
    let off2 = off;
    let _0xd4c257 = _0xa44dd5(off2, KEYS_CHAR_SELECT);
    if (_0xd4c257.length > 0) {
      _0x48b995 = _0xd4c257;
      _0x1704dc = "offsets missing";
      return false;
    }
    _0x48b995 = [];
    let _0x1d7560 = _0x524517(off2.tiGameDataManager, "GameDataManager TypeInfo");
    if (_0x1d7560 !== null) {
      _0x1704dc = _0x1d7560;
      return false;
    } else {
      _0x1704dc = "";
      return true;
    }
  }
  function _0x4b61a6(_0x3d01d7) {
    let _0x5b5877;
    try {
      _0x5b5877 = _0x464c74(_0x3d01d7);
    } catch (_0x30bfb3) {
      _0x5b5877 = "" + _0x30bfb3;
    }
    if (typeof _0x5b5877 == "string") {
      send({
        t: "skill_tab_ids",
        tab: _0x3d01d7,
        ok: false,
        ids: [],
        why: _0x5b5877
      });
      return;
    }
    send({
      t: "skill_tab_ids",
      tab: _0x3d01d7,
      ok: true,
      ids: _0x5b5877
    });
  }
  function _0x464c74(_0x23e0ba) {
    if (!_0x923b4d) {
      return "window file offsets not loaded";
    }
    if (_0x23e0ba !== 1 && _0x23e0ba !== 2 && _0x23e0ba !== 3) {
      return "tab " + _0x23e0ba + " is not 1, 2 or 3";
    }
    let off2 = off;
    let _0x38edef = _0x35e499(off2.tiGameDataManager, off2.sfGdmInstance);
    if (_0x38edef.isNull()) {
      return "no GameDataManager instance yet";
    }
    let gdmCharSelectPtr = _0x38edef.add(off2.gdmCharSelect).readPointer();
    if (gdmCharSelectPtr.isNull()) {
      return "no character select data yet";
    }
    let csId = gdmCharSelectPtr.add(off2.csId).readU32();
    if (csId === 0) {
      return "no character selected";
    }
    let _0x2fe9e8 = _0x2aa668 + "/" + csId + "/" + _0x1a59ec + _0x23e0ba;
    let _0x3cdbd0;
    try {
      _0x3cdbd0 = File.readAllText(_0x2fe9e8);
    } catch (_0xcd71e1) {
      return "cannot read window file " + _0x23e0ba + ": " + _0xcd71e1;
    }
    return _0x2cc0a4(_0x3cdbd0);
  }
  function _0x2cc0a4(_0x23a4fe) {
    let _0x1ff8e8 = _0x23a4fe.charCodeAt(0) === 65279 ? _0x23a4fe.slice(1) : _0x23a4fe;
    let _0x34fa09;
    try {
      _0x34fa09 = JSON.parse(_0x1ff8e8);
    } catch (_0x2d8f04) {
      return "window file is not JSON: " + _0x2d8f04;
    }
    if (_0x34fa09 === null || typeof _0x34fa09 != "object") {
      return "window file is not a JSON object";
    }
    if (!Array.isArray(_0x34fa09.Slots)) {
      return "window file has no Slots";
    }
    let _0x32b548 = [];
    for (let _0x14d1e4 = 0; _0x14d1e4 < _0x24f684; _0x14d1e4++) {
      let _0x27186e = _0x34fa09.Slots[_0x14d1e4];
      let _0x2d69b5 = _0x87a098;
      let _0x2252f7 = _0x87a098;
      if (_0x27186e != null && _0x27186e.skill != null && typeof _0x27186e.skill.mainId == "number" && typeof _0x27186e.skill.subId == "number") {
        _0x2d69b5 = _0x27186e.skill.mainId;
        _0x2252f7 = _0x27186e.skill.subId;
      }
      _0x32b548.push(_0x2d69b5 + ":" + _0x2252f7);
    }
    return _0x32b548;
  }
  function _0x357a28() {
    let off2 = off;
    let _0x932f2e = _0xa44dd5(off2, KEYS_INVENTORY);
    if (_0x932f2e.length > 0) {
      _0x18c945 = _0x932f2e;
      _0x5590df = "offsets missing";
      return false;
    }
    _0x18c945 = [];
    let _0x129e03 = _0x524517(off2.tiInstanceContainer, "InstanceContainer TypeInfo");
    if (_0x129e03 !== null) {
      _0x5590df = _0x129e03;
      return false;
    }
    let _0x1049e9 = _0x3166d6(off2.rvaBagGetItemObject, "InventorySlot.GetItemObject");
    if (typeof _0x1049e9 == "string") {
      _0x5590df = _0x1049e9;
      return false;
    } else {
      _0x5a95f5 = new NativeFunction(_0x9ca124.add(off2.rvaBagGetItemObject), "pointer", ["pointer", "pointer"]);
      _0x5590df = "";
      return true;
    }
  }
  function _0x2a3267(_0x4e65a0, _0x5921de) {
    let off2 = off;
    let _0x1d71f5 = _0x4e65a0.add(_0x5921de).readPointer();
    if (_0x1d71f5.isNull()) {
      return NULL;
    }
    let ioContainerPtr = _0x1d71f5.add(off2.ioContainer).readPointer();
    if (ioContainerPtr.isNull()) {
      return NULL;
    } else {
      return ioContainerPtr.add(off2.invSlots).readPointer();
    }
  }
  function _0x2b0763(_0x2eb1dd) {
    let off2 = off;
    let slotItemPosPtr = _0x2eb1dd.add(off2.slotItemPos).readPointer();
    if (slotItemPosPtr.isNull() || slotItemPosPtr.add(off2.arrCount).readU32() === 0) {
      return 0;
    } else {
      return slotItemPosPtr.add(off2.arrFirst).readU8();
    }
  }
  function _0x46fa79(_0x1531e4, _0x45f295, _0x47551d, _0x1a7392 = null) {
    let off2 = off;
    if (_0x3ec545[_0x45f295] || _0x47551d[_0x45f295] !== undefined) {
      return;
    }
    let _0x5befeb = _0x1a7392 === null ? _0x5a95f5(_0x1531e4, NULL) : _0x1a7392;
    if (!_0x5befeb.isNull()) {
      _0x183647(_0x3ec545, _0x47551d, _0x45f295, () => _0x2df1c6(_0x5befeb, off2.itemObjName));
    }
  }
  function _0xf36194(_0x35866c, _0x5b710e, _0x244cf3) {
    let off2 = off;
    let _0x5accef = [];
    for (let _0x5cda8a = 0; _0x5cda8a < _0x5b710e; _0x5cda8a++) {
      let _0x5de506 = _0x35866c.add(off2.arrFirst + _0x5cda8a * off2.arrStride).readPointer();
      if (_0x5de506.isNull()) {
        continue;
      }
      let slotAmount = _0x5de506.add(off2.slotAmount).readS32();
      if (slotAmount <= 0) {
        continue;
      }
      let slotItemPtr = _0x5de506.add(off2.slotItem).readPointer();
      if (slotItemPtr.isNull()) {
        continue;
      }
      let itemMainId = slotItemPtr.add(off2.itemMainId).readS32();
      let itemSubId = slotItemPtr.add(off2.itemSubId).readS32();
      let _0x5f47c6 = _0x5a95f5(_0x5de506, NULL);
      _0x46fa79(_0x5de506, itemMainId + ":" + itemSubId, _0x244cf3, _0x5f47c6);
      let _0x240842 = _0x5f47c6.isNull() ? null : _0x5f47c6.add(off2.itemObjType).readU8();
      _0x5accef.push({
        i: _0x5de506.add(off2.slotIndex).readS32(),
        ord: _0x5cda8a,
        main: itemMainId,
        sub: itemSubId,
        amt: slotAmount,
        type: _0x240842
      });
    }
    return _0x5accef;
  }
  function _0x3d6547(_0x5440c5, _0x31d003) {
    let off2 = off;
    let _0x28b4ec = [];
    for (let _0x1e5014 = 0; _0x1e5014 < _0x2d34ea; _0x1e5014++) {
      let _0x34c4d2 = _0x5440c5.add(off2.arrFirst + _0x1e5014 * off2.arrStride).readPointer();
      if (_0x34c4d2.isNull()) {
        _0x28b4ec.push({
          i: _0x1e5014,
          pos: 0,
          main: _0x87a098,
          sub: _0x87a098,
          amt: 0
        });
        continue;
      }
      let slotIndex = _0x34c4d2.add(off2.slotIndex).readS32();
      let _0x53945a = _0x2b0763(_0x34c4d2);
      let slotAmount = _0x34c4d2.add(off2.slotAmount).readS32();
      let slotItemPtr = _0x34c4d2.add(off2.slotItem).readPointer();
      if (slotItemPtr.isNull()) {
        _0x28b4ec.push({
          i: slotIndex,
          pos: _0x53945a,
          main: _0x87a098,
          sub: _0x87a098,
          amt: slotAmount
        });
        continue;
      }
      let itemMainId = slotItemPtr.add(off2.itemMainId).readS32();
      let itemSubId = slotItemPtr.add(off2.itemSubId).readS32();
      if (itemMainId !== _0x87a098) {
        _0x46fa79(_0x34c4d2, itemMainId + ":" + itemSubId, _0x31d003);
      }
      _0x28b4ec.push({
        i: slotIndex,
        pos: _0x53945a,
        main: itemMainId,
        sub: itemSubId,
        amt: slotAmount
      });
    }
    return _0x28b4ec;
  }
  function _0x3c2d2e() {
    let off2 = off;
    if (_0x298ea0.isNull()) {
      return _0x1a194d;
    }
    let _0x5a66c2 = _0x298ea0.add(off2.phInvenLine).readU8() + _0x4f77d0;
    if (_0x5a66c2 > _0x140423) {
      _0x5a66c2 = _0x140423;
    }
    return _0x5a66c2 * _0x2fe159;
  }
  function _0x5975c9() {
    if (!_0x545f85) {
      send({
        t: "bag",
        ok: false,
        error: "bag offsets not loaded"
      });
      return;
    }
    let off2 = off;
    if (!_0x5b8db7(() => {
      try {
        let _0x27e903 = _0x35e499(off2.tiInstanceContainer, off2.icInstance);
        if (_0x27e903.isNull()) {
          send({
            t: "bag",
            ok: false,
            error: "no instance container yet"
          });
          return;
        }
        let _0x470924 = _0x2a3267(_0x27e903, off2.icInventory);
        if (_0x470924.isNull()) {
          send({
            t: "bag",
            ok: false,
            error: "no inventory slots yet"
          });
          return;
        }
        let _0x545fbf = _0x2a3267(_0x27e903, off2.icEquipment);
        if (_0x545fbf.isNull()) {
          send({
            t: "bag",
            ok: false,
            error: "no equipment slots yet"
          });
          return;
        }
        let arrCount = _0x545fbf.add(off2.arrCount).readU32();
        if (arrCount !== _0x2d34ea) {
          send({
            t: "bag",
            ok: false,
            error: "the equipment container holds " + arrCount + " slots, not " + _0x2d34ea
          });
          return;
        }
        let _0x423094 = {};
        let arrCount2 = _0x470924.add(off2.arrCount).readU32();
        let _0xe6a1a9 = _0xf36194(_0x470924, arrCount2, _0x423094);
        let _0x39f5dc = _0x3d6547(_0x545fbf, _0x423094);
        for (let _0x5554a2 of Object.keys(_0x423094)) {
          _0x3ec545[_0x5554a2] = true;
        }
        let _0x5d5cd0 = _0x3c2d2e();
        _0xa75ccc++;
        send({
          t: "bag",
          ok: true,
          seq: _0xa75ccc,
          bag: _0xe6a1a9,
          equip: _0x39f5dc,
          inames: _0x423094,
          cap: _0x5d5cd0,
          slots: arrCount2
        });
      } catch (_0x1c3704) {
        send({
          t: "bag",
          ok: false,
          error: "" + _0x1c3704
        });
      }
    })) {
      send({
        t: "bag",
        ok: false,
        error: "frame queue unavailable"
      });
    }
  }
  function _0x2a8986() {
    let _0x49676a = {
      ready: _0x120702,
      fullness: null,
      activeSlot: null,
      globalId: null,
      objectPresent: null
    };
    if (!_0x120702 || off === null) {
      return _0x49676a;
    }
    let off2 = off;
    try {
      return {
        ready: true,
        fullness: _0x53c8d0.isNull() ? null : _0x53c8d0.add(off2.scmPetFullness).readU16(),
        activeSlot: _0x298ea0.isNull() ? null : _0x298ea0.add(off2.phActivePetCardSlot).readU16(),
        globalId: _0x298ea0.isNull() ? null : _0x298ea0.add(off2.phPetGlobalId).readU32(),
        objectPresent: _0x298ea0.isNull() ? null : !_0x298ea0.add(off2.phPetObject).readPointer().isNull()
      };
    } catch {
      return _0x49676a;
    }
  }
  function _0x17d773(_0x395574, _0x480bb7, _0xbc9fb2) {
    send({
      t: "pet_request",
      action: _0x395574 === null ? null : _0x395574.action,
      req: _0x395574 === null ? 0 : _0x395574.req,
      ok: _0x480bb7,
      serverConfirmed: false,
      error: _0xbc9fb2
    });
  }
  function _0x36d806(_0x301ea7) {
    let _0x16a819 = _0x109505.reset();
    if (_0xf15267 !== null) {
      clearTimeout(_0xf15267);
      _0xf15267 = null;
    }
    if (_0x16a819 !== null) {
      send({
        t: "pet_response",
        action: _0x16a819.action,
        req: _0x16a819.req,
        ok: false,
        error: _0x301ea7
      });
    }
    if (_0x533468 !== null) {
      try {
        _0x533468.detach();
      } catch {}
      _0x533468 = null;
    }
    if (_0x5e6944 !== null) {
      try {
        _0x5e6944.detach();
      } catch {}
      _0x5e6944 = null;
    }
    _0x22271f = null;
    _0x1078f7 = null;
    _0x20ad38 = null;
    _0x120702 = false;
    _0x335116 = [];
    _0x38c3ed = _0x301ea7;
  }
  function _0x17ac2a(_0x341096, _0x4cc7b3, _0x163599) {
    let _0x3bd1ee = _0x109505.finish(_0x341096);
    if (_0x3bd1ee !== null && _0xf15267 !== null) {
      clearTimeout(_0xf15267);
      _0xf15267 = null;
    }
    send({
      t: "pet_response",
      action: _0x3bd1ee === null ? null : _0x3bd1ee.action,
      req: _0x3bd1ee === null ? 0 : _0x3bd1ee.req,
      result: _0x4cc7b3,
      ok: _0x4cc7b3 === 0,
      ..._0x163599
    });
  }
  function _0x42b772() {
    let off2 = off;
    _0x335116 = _0xa44dd5(off2, KEYS_PET);
    if (_0x335116.length > 0) {
      _0x38c3ed = "offsets missing";
      return false;
    }
    if (!_0x545f85) {
      _0x38c3ed = "bag offsets not loaded";
      return false;
    }
    let _0x1736b1 = [{
      rva: off2.rvaPetGiveFood,
      what: "ServerConnectionManager.SendPetGiveFood"
    }, {
      rva: off2.rvaPetSummon,
      what: "ServerConnectionManager.SendPetSummon"
    }, {
      rva: off2.rvaPetDismiss,
      what: "ServerConnectionManager.SendPetDismiss"
    }, {
      rva: off2.rvaPetGiveFoodResponse,
      what: "ServerConnectionManager.HandlePetGiveFoodResponse"
    }, {
      rva: off2.rvaPetSummonResponse,
      what: "ServerConnectionManager.HandlePetSummonResponse"
    }];
    for (let _0x44e9d5 of _0x1736b1) {
      let _0x2757d1 = _0x3166d6(_0x44e9d5.rva, _0x44e9d5.what);
      if (typeof _0x2757d1 == "string") {
        _0x38c3ed = _0x2757d1;
        return false;
      }
    }
    let _0x2a25b0 = _0x5c5ec5(off2.rvaPickAnchor);
    if (_0x2a25b0 !== null) {
      _0x38c3ed = _0x2a25b0;
      return false;
    }
    _0x22271f = new NativeFunction(_0x9ca124.add(off2.rvaPetGiveFood), "void", ["pointer", "uint16", "uint16", "pointer"]);
    _0x1078f7 = new NativeFunction(_0x9ca124.add(off2.rvaPetSummon), "void", ["pointer", "uint16", "pointer"]);
    _0x20ad38 = new NativeFunction(_0x9ca124.add(off2.rvaPetDismiss), "void", ["pointer", "pointer"]);
    try {
      _0x533468 = Interceptor.attach(_0x9ca124.add(off2.rvaPetGiveFoodResponse), {
        onEnter(args) {
          try {
            let _0x2dc272 = args[1];
            _0x17ac2a("feed", _0x2dc272.add(off2.petFoodResult).readU8(), {
              newFullness: _0x2dc272.add(off2.petFoodNewFullness).readU16(),
              consumedSlot: _0x2dc272.add(off2.petFoodConsumedSlot).readU16()
            });
          } catch (_0x54cdb1) {
            send({
              t: "pet_response",
              kind: "feed",
              ok: false,
              error: "" + _0x54cdb1
            });
          }
        }
      });
      _0x5e6944 = Interceptor.attach(_0x9ca124.add(off2.rvaPetSummonResponse), {
        onEnter(args) {
          try {
            let _0x2a1cd1 = args[1];
            _0x17ac2a("summon", _0x2a1cd1.add(off2.petSummonResult).readU8(), {
              globalId: _0x2a1cd1.add(off2.petSummonGlobalId).readU32(),
              cardSlot: _0x2a1cd1.add(off2.petSummonCardSlot).readU16()
            });
          } catch (_0x20476e) {
            send({
              t: "pet_response",
              kind: "summon",
              ok: false,
              error: "" + _0x20476e
            });
          }
        }
      });
    } catch (_0x4bfe5a) {
      _0x36d806("response hook failed: " + _0x4bfe5a);
      return false;
    }
    _0x38c3ed = "";
    return true;
  }
  function _0x2f1336(_0x20adc8, _0x29856c, _0x2b7b72, _0x1dd588) {
    let off2 = off;
    let _0x1d4fda = _0x35e499(off2.tiInstanceContainer, off2.icInstance);
    if (_0x1d4fda.isNull()) {
      return "no instance container yet";
    }
    let _0x527c67 = _0x2a3267(_0x1d4fda, off2.icInventory);
    if (_0x527c67.isNull()) {
      return "no inventory slots yet";
    }
    let arrCount = _0x527c67.add(off2.arrCount).readU32();
    let _0x570f57 = NULL;
    for (let _0x5b151f = 0; _0x5b151f < arrCount; _0x5b151f++) {
      let _0x5823ba = _0x3442b0(_0x527c67, arrCount, _0x5b151f);
      if (!_0x5823ba.isNull() && _0x5823ba.add(off2.slotIndex).readS32() === _0x20adc8) {
        if (!_0x570f57.isNull()) {
          return "duplicate slot index";
        }
        _0x570f57 = _0x5823ba;
      }
    }
    if (_0x570f57.isNull()) {
      return _0x154298(null, _0x20adc8, _0x29856c, _0x2b7b72, _0x1dd588);
    }
    let slotAmount = _0x570f57.add(off2.slotAmount).readS32();
    let slotItemPtr = _0x570f57.add(off2.slotItem).readPointer();
    let _0xa0b0bb = slotAmount > 0 && !slotItemPtr.isNull() ? _0x5a95f5(_0x570f57, NULL) : NULL;
    let _0x34b569 = {
      index: _0x570f57.add(off2.slotIndex).readS32(),
      amount: slotAmount,
      main: slotItemPtr.isNull() ? -1 : slotItemPtr.add(off2.itemMainId).readS32(),
      sub: slotItemPtr.isNull() ? -1 : slotItemPtr.add(off2.itemSubId).readS32(),
      type: _0xa0b0bb.isNull() ? null : _0xa0b0bb.add(off2.itemObjType).readU8()
    };
    return _0x154298(_0x34b569, _0x20adc8, _0x29856c, _0x2b7b72, _0x1dd588);
  }
  function _0x35efde(_0x3fb8ee) {
    let _0xafe3f4 = _0x3fb8ee.action;
    if (_0xafe3f4 !== "feed" && _0xafe3f4 !== "summon" && _0xafe3f4 !== "dismiss") {
      send({
        t: "pet_request",
        action: _0x3fb8ee.action,
        req: _0x3fb8ee.req || 0,
        ok: false,
        serverConfirmed: false,
        error: "invalid action"
      });
      return;
    }
    if (!_0x120702) {
      send({
        t: "pet_request",
        action: _0xafe3f4,
        req: _0x3fb8ee.req || 0,
        ok: false,
        serverConfirmed: false,
        error: "pet offsets not loaded"
      });
      return;
    }
    if (_0xafe3f4 !== "dismiss" && (!_0x233988(_0x3fb8ee.cardSlot) || !_0x196649(_0x3fb8ee.cardMain) || !_0x196649(_0x3fb8ee.cardSub))) {
      send({
        t: "pet_request",
        action: _0xafe3f4,
        req: _0x3fb8ee.req || 0,
        ok: false,
        serverConfirmed: false,
        error: "invalid pet card identity"
      });
      return;
    }
    if (_0xafe3f4 === "feed" && (!_0x233988(_0x3fb8ee.foodSlot) || !_0x196649(_0x3fb8ee.foodMain) || !_0x196649(_0x3fb8ee.foodSub))) {
      send({
        t: "pet_request",
        action: _0xafe3f4,
        req: _0x3fb8ee.req || 0,
        ok: false,
        serverConfirmed: false,
        error: "invalid pet food identity"
      });
      return;
    }
    let _0x44cdc9 = _0x109505.begin(_0xafe3f4, _0x3fb8ee.req, Date.now(), _0x442f8f);
    if (_0x44cdc9.error !== null) {
      send({
        t: "pet_request",
        action: _0xafe3f4,
        req: _0x3fb8ee.req || 0,
        ok: false,
        serverConfirmed: false,
        error: _0x44cdc9.error
      });
      return;
    }
    let _0x837a75 = _0x44cdc9.job;
    if (!_0x5b8db7(() => {
      try {
        if (_0x53c8d0.isNull()) {
          throw new Error("no server connection yet");
        }
        let off2 = off;
        if (_0xafe3f4 !== "dismiss") {
          let _0x36dcc6 = _0x2f1336(_0x3fb8ee.cardSlot, _0x3fb8ee.cardMain, _0x3fb8ee.cardSub, 51);
          if (_0x36dcc6 !== null) {
            throw new Error("pet card: " + _0x36dcc6);
          }
        }
        if (_0xafe3f4 === "feed") {
          let _0x43a691 = _0x2f1336(_0x3fb8ee.foodSlot, _0x3fb8ee.foodMain, _0x3fb8ee.foodSub, 52);
          if (_0x43a691 !== null) {
            throw new Error("pet food: " + _0x43a691);
          }
          _0x22271f(_0x53c8d0, _0x3fb8ee.foodSlot, _0x3fb8ee.cardSlot, NULL);
        } else if (_0xafe3f4 === "summon") {
          if (_0x298ea0.isNull()) {
            throw new Error("no player handler yet");
          }
          let phActivePetCardSlot = _0x298ea0.add(off2.phActivePetCardSlot).readU16();
          let _0x1fecf6 = !_0x298ea0.add(off2.phPetObject).readPointer().isNull();
          if (phActivePetCardSlot !== 65535 || _0x1fecf6) {
            throw new Error("a pet is already active");
          }
          _0x1078f7(_0x53c8d0, _0x3fb8ee.cardSlot, NULL);
        } else {
          if (_0x298ea0.isNull()) {
            throw new Error("no player handler yet");
          }
          let phActivePetCardSlot = _0x298ea0.add(off2.phActivePetCardSlot).readU16();
          let _0x5d90e7 = !_0x298ea0.add(off2.phPetObject).readPointer().isNull();
          if (phActivePetCardSlot === 65535 && !_0x5d90e7) {
            throw new Error("no active pet");
          }
          _0x20ad38(_0x53c8d0, NULL);
        }
        _0x17d773(_0x837a75, true, "");
        if (_0x109505.busy) {
          _0xf15267 = setTimeout(() => {
            let _0x5b6cb3 = _0x109505.expire(Date.now());
            _0xf15267 = null;
            if (_0x5b6cb3 !== null) {
              send({
                t: "pet_response",
                action: _0x5b6cb3.action,
                req: _0x5b6cb3.req,
                ok: false,
                error: "response timeout"
              });
            }
          }, _0x442f8f);
        }
      } catch (_0x2faab0) {
        _0x109505.reset();
        _0x17d773(_0x837a75, false, "" + _0x2faab0);
      }
    })) {
      _0x109505.reset();
      _0x17d773(_0x837a75, false, "frame queue unavailable");
    }
  }
  function _0x55be7c() {
    let off2 = off;
    let _0x287698 = _0xa44dd5(off2, KEYS_NPC_SALE);
    if (_0x287698.length > 0) {
      _0x26d215 = _0x287698;
      _0x207859 = "offsets missing";
      return false;
    }
    _0x26d215 = [];
    let _0x2d3684 = _0x3166d6(off2.rvaNpcSaleRequest, "ServerConnectionManager.SendNpcSaleRequest");
    if (typeof _0x2d3684 == "string") {
      _0x207859 = _0x2d3684;
      return false;
    } else {
      _0xaba49a = new NativeFunction(_0x9ca124.add(off2.rvaNpcSaleRequest), "void", ["pointer", "uint16", "uint16", "pointer"]);
      _0x207859 = "";
      return true;
    }
  }
  var _0x1f4fb3 = 500;
  var _0x52c8c6 = null;
  function _0x146a5f(_0x356e64) {
    if (!Array.isArray(_0x356e64) || _0x356e64.length === 0) {
      return null;
    }
    let _0x26bfb3 = [];
    for (let _0x372b8b = 0; _0x372b8b < _0x356e64.length; _0x372b8b++) {
      let _0x16707c = _0x356e64[_0x372b8b];
      if (_0x16707c === null || typeof _0x16707c != "object" || !_0x196649(_0x16707c.slot) || !Number.isInteger(_0x16707c.ord) || _0x16707c.ord < 0 || !_0x196649(_0x16707c.main) || !_0x196649(_0x16707c.sub)) {
        return null;
      }
      _0x26bfb3.push({
        slot: _0x16707c.slot,
        ord: _0x16707c.ord,
        main: _0x16707c.main,
        sub: _0x16707c.sub
      });
    }
    return _0x26bfb3;
  }
  function _0x3442b0(_0x21740, _0x3f6440, _0x16e9b7) {
    let off2 = off;
    if (_0x16e9b7 < 0 || _0x16e9b7 >= _0x3f6440) {
      return NULL;
    } else {
      return _0x21740.add(off2.arrFirst + _0x16e9b7 * off2.arrStride).readPointer();
    }
  }
  function _0x2f1a87(_0x3e76c1, _0x3c0713, _0x2aa4b5) {
    let off2 = off;
    if (_0x3e76c1.isNull() || _0x3e76c1.add(off2.slotAmount).readS32() <= 0) {
      return false;
    }
    let slotItemPtr = _0x3e76c1.add(off2.slotItem).readPointer();
    if (slotItemPtr.isNull()) {
      return false;
    } else {
      return slotItemPtr.add(off2.itemMainId).readS32() === _0x3c0713 && slotItemPtr.add(off2.itemSubId).readS32() === _0x2aa4b5;
    }
  }
  function _0x4c083b(_0xf39ab2, _0x33ec60) {
    if (!_0x526164) {
      send({
        t: "sell",
        ok: false,
        error: "sell offsets not loaded"
      });
      return;
    }
    if (!_0x545f85) {
      send({
        t: "sell",
        ok: false,
        error: "bag offsets not loaded"
      });
      return;
    }
    let _0x3027d9 = _0xf39ab2;
    let _0xe86ec6 = _0x146a5f(_0x33ec60);
    if (!_0x196649(_0x3027d9)) {
      send({
        t: "sell",
        ok: false,
        error: "invalid npc id"
      });
      return;
    }
    if (_0xe86ec6 === null) {
      send({
        t: "sell",
        ok: false,
        error: "invalid sale entries"
      });
      return;
    }
    if (_0x53c8d0.isNull()) {
      send({
        t: "sell",
        ok: false,
        error: "no server connection yet"
      });
      return;
    }
    if (_0x52c8c6 !== null) {
      send({
        t: "sell",
        ok: false,
        error: "a sale batch is already running"
      });
      return;
    }
    _0x52c8c6 = {
      npc: _0x3027d9,
      entries: _0xe86ec6,
      outcomes: [],
      next: 0,
      lastSendAt: 0,
      timer: null
    };
    _0x164710();
  }
  function _0x164710() {
    let _0x268363 = _0x52c8c6;
    if (_0x268363 === null) {
      return;
    }
    if (!_0x5b8db7(() => {
      if (_0x52c8c6 !== null) {
        try {
          let off2 = off;
          let _0x367baa = _0x35e499(off2.tiInstanceContainer, off2.icInstance);
          if (_0x367baa.isNull()) {
            _0x20ad63("no instance container yet");
            return;
          }
          let _0x279044 = _0x2a3267(_0x367baa, off2.icInventory);
          if (_0x279044.isNull()) {
            _0x20ad63("no inventory slots yet");
            return;
          }
          let arrCount = _0x279044.add(off2.arrCount).readU32();
          let _0x19fbe1 = _0x268363.npc;
          let _0x2f2e9d = _0x268363.entries[_0x268363.next];
          let _0x48b6d3 = _0x3442b0(_0x279044, arrCount, _0x2f2e9d.ord);
          if (!_0x2f1a87(_0x48b6d3, _0x2f2e9d.main, _0x2f2e9d.sub)) {
            _0x268363.outcomes.push({
              slot: _0x2f2e9d.slot,
              ord: _0x2f2e9d.ord,
              main: _0x2f2e9d.main,
              sub: _0x2f2e9d.sub,
              matched: false,
              attempted: false,
              gone: false,
              outcome: "skipped"
            });
          } else {
            _0xaba49a(_0x53c8d0, _0x19fbe1, _0x2f2e9d.slot, NULL);
            let _0x431ab5 = true;
            let _0x2c128f = _0x3442b0(_0x279044, arrCount, _0x2f2e9d.ord);
            let _0x58bcda = !_0x2f1a87(_0x2c128f, _0x2f2e9d.main, _0x2f2e9d.sub);
            let _0x4b52e6 = _0x58bcda ? "sold" : "nochange";
            _0x268363.outcomes.push({
              slot: _0x2f2e9d.slot,
              ord: _0x2f2e9d.ord,
              main: _0x2f2e9d.main,
              sub: _0x2f2e9d.sub,
              matched: true,
              attempted: _0x431ab5,
              gone: _0x58bcda,
              outcome: _0x4b52e6
            });
            _0x268363.lastSendAt = Date.now();
          }
          _0x268363.next++;
          if (_0x268363.next >= _0x268363.entries.length) {
            _0x20ad63(null);
            return;
          }
          let _0x46a20c = _0x268363.lastSendAt === 0 ? 0 : Math.max(0, _0x1f4fb3 - (Date.now() - _0x268363.lastSendAt));
          _0x268363.timer = setTimeout(_0x164710, _0x46a20c);
        } catch (_0xc91ae1) {
          _0x20ad63("" + _0xc91ae1);
        }
      }
    })) {
      _0x20ad63("frame queue unavailable");
    }
  }
  function _0x20ad63(_0x21c2b4) {
    let _0x32aad1 = _0x52c8c6;
    if (_0x32aad1 === null) {
      return;
    }
    _0x52c8c6 = null;
    if (_0x32aad1.timer !== null) {
      clearTimeout(_0x32aad1.timer);
      _0x32aad1.timer = null;
    }
    if (_0x21c2b4 !== null) {
      send({
        t: "sell",
        ok: false,
        error: _0x21c2b4
      });
      return;
    }
    let _0x1a7812 = "complete";
    let _0x5b213d = _0x32aad1.outcomes;
    _0x43d22f++;
    send({
      t: "sell",
      ok: true,
      seq: _0x43d22f,
      state: _0x1a7812,
      outcomes: _0x5b213d
    });
  }
  var _0x58f4ec = false;
  var _0x6a2faf = [];
  var _0x29f4e4 = "offsets not applied";
  var _0x191b52 = 0;
  var _0x4b9447 = null;
  var _0x53b669 = 0;
  var _0x946bd8 = 3000;
  var _0x56163d = 4096;
  function _0x1ddb01() {
    let off2 = off;
    let _0x3f3b3b = _0xa44dd5(off2, KEYS_FRIENDS);
    if (_0x3f3b3b.length > 0) {
      _0x6a2faf = _0x3f3b3b;
      _0x29f4e4 = "offsets missing";
      return false;
    }
    _0x6a2faf = [];
    let _0x11b402 = _0x524517(off2.tiCharacterFriendManager, "CharacterFriendManager TypeInfo");
    if (_0x11b402 !== null) {
      _0x29f4e4 = _0x11b402;
      return false;
    }
    let _0xafdd0 = _0x3166d6(off2.rvaGetFriends, "CharacterFriendManager.GetFriends");
    if (typeof _0xafdd0 == "string") {
      _0x29f4e4 = _0xafdd0;
      return false;
    } else {
      _0x4b9447 = new NativeFunction(_0x9ca124.add(off2.rvaGetFriends), "void", ["pointer", "pointer"]);
      _0x53b669 = 0;
      _0x29f4e4 = "";
      return true;
    }
  }
  function _0x3da0da(_0x2acd92) {
    let off2 = off;
    let _0x4a4ee7 = [];
    let listItemsPtr = _0x2acd92.add(off2.listItems).readPointer();
    if (listItemsPtr.isNull()) {
      return _0x4a4ee7;
    }
    let listSize = _0x2acd92.add(off2.listSize).readS32();
    if (listSize <= 0) {
      return _0x4a4ee7;
    }
    if (listSize > _0x56163d) {
      listSize = _0x56163d;
    }
    for (let _0x4c92a2 = 0; _0x4c92a2 < listSize; _0x4c92a2++) {
      let _0x591e70 = listItemsPtr.add(off2.arrFirst + _0x4c92a2 * off2.fceStride);
      _0x4a4ee7.push({
        name: _0x2df1c6(_0x591e70, off2.fceName),
        id: _0x591e70.add(off2.fceId).readS32(),
        flag: _0x591e70.add(off2.fceFlag).readS8(),
        online: _0x591e70.add(off2.fceOnline).readU8() !== 0,
        known: _0x591e70.add(off2.fceKnown).readU8() !== 0,
        ch: _0x591e70.add(off2.fceChannel).readU8(),
        lv: _0x591e70.add(off2.fceLevel).readU16(),
        cls: _0x591e70.add(off2.fceClass).readU8(),
        sch: _0x591e70.add(off2.fceSchool).readU8()
      });
    }
    return _0x4a4ee7;
  }
  function _0x1c2222() {
    if (!_0x58f4ec) {
      send({
        t: "friends",
        ok: false,
        error: "friend offsets not loaded"
      });
      return;
    }
    let off2 = off;
    if (!_0x5b8db7(() => {
      try {
        let _0x123f1e = _0x35e499(off2.tiCharacterFriendManager, off2.sfFriendMgrInstance);
        if (_0x123f1e.isNull()) {
          send({
            t: "friends",
            ok: false,
            error: "no friend manager yet; enter the world first"
          });
          return;
        }
        let _0xa49183 = _0x123f1e.add(off2.fmListLoaded).readU8() !== 0;
        let _0x4f7bd5 = false;
        if (!_0xa49183) {
          let _0x2f9366 = Date.now();
          if (_0x53b669 === 0 || _0x2f9366 - _0x53b669 >= _0x946bd8) {
            _0x4b9447(_0x123f1e, NULL);
            _0x53b669 = _0x2f9366;
            _0x4f7bd5 = true;
          }
        }
        let fmFriendsPtr = _0x123f1e.add(off2.fmFriends).readPointer();
        let _0x30a2b5 = fmFriendsPtr.isNull() ? [] : _0x3da0da(fmFriendsPtr);
        let _0x293e97 = "refreshing";
        if (_0xa49183) {
          _0x293e97 = _0x30a2b5.length > 0 ? "ready" : "empty";
        }
        _0x191b52++;
        send({
          t: "friends",
          ok: true,
          seq: _0x191b52,
          state: _0x293e97,
          loaded: _0xa49183,
          asked: _0x4f7bd5,
          friends: _0x30a2b5
        });
      } catch (_0x4565c2) {
        send({
          t: "friends",
          ok: false,
          error: "" + _0x4565c2
        });
      }
    })) {
      send({
        t: "friends",
        ok: false,
        error: "frame queue unavailable"
      });
    }
  }
  function _0x15d0cb() {
    let off2 = off;
    let _0x1f0a16 = _0xa44dd5(off2, KEYS_RECALL);
    if (_0x1f0a16.length > 0) {
      _0x40d52d = _0x1f0a16;
      _0x37d827 = "offsets missing";
      return false;
    }
    _0x40d52d = [];
    let _0x75dbb9 = _0x3166d6(off2.rvaRecallCardRequest, "ServerConnectionManager.SendRecallCardRequest");
    if (typeof _0x75dbb9 == "string") {
      _0x37d827 = _0x75dbb9;
      return false;
    } else {
      _0x3f745b = new NativeFunction(_0x9ca124.add(off2.rvaRecallCardRequest), "void", ["pointer", "uint16", "pointer"]);
      _0x37d827 = "";
      return true;
    }
  }
  function _0x5e643d() {
    let off2 = off;
    let _0x1075fa = _0xa44dd5(off2, KEYS_FRIEND_WARP);
    if (_0x1075fa.length > 0) {
      _0x345e5a = _0x1075fa;
      _0x3924ee = "offsets missing";
      return false;
    }
    _0x345e5a = [];
    let _0x1ee76c = _0x3166d6(off2.rvaFriendMoveRequest, "ServerConnectionManager.SendFriendMoveRequest");
    if (typeof _0x1ee76c == "string") {
      _0x3924ee = _0x1ee76c;
      return false;
    } else {
      _0x24fb9b = new NativeFunction(_0x9ca124.add(off2.rvaFriendMoveRequest), "void", ["pointer", "pointer", "uint16", "pointer"]);
      _0x3924ee = "";
      return true;
    }
  }
  function _0x149b3b(_0x2b58f9, _0x13538e, _0xa08d8a) {
    return Number.isInteger(_0x2b58f9) && _0x2b58f9 >= 0 && _0x196649(_0x13538e) && _0x196649(_0xa08d8a);
  }
  function _0x5700eb(_0xc01e04, _0x4068a8, _0x4b9d52, _0x2cb95a = false) {
    let off2 = off;
    let _0x1b1236 = _0x35e499(off2.tiInstanceContainer, off2.icInstance);
    if (_0x1b1236.isNull()) {
      return "no instance container yet";
    }
    let _0x5030d6 = _0x2a3267(_0x1b1236, off2.icInventory);
    if (_0x5030d6.isNull()) {
      return "no inventory slots yet";
    }
    let arrCount = _0x5030d6.add(off2.arrCount).readU32();
    let _0xf76e32 = _0x3442b0(_0x5030d6, arrCount, _0xc01e04);
    if (_0xf76e32.isNull() || _0xf76e32.add(off2.slotAmount).readS32() <= 0) {
      return _0x27ee2b(false, false, _0x2cb95a, null);
    }
    if (!_0x2f1a87(_0xf76e32, _0x4068a8, _0x4b9d52)) {
      return _0x27ee2b(true, false, _0x2cb95a, null);
    }
    if (_0x2cb95a) {
      let _0x3188fb = _0x5a95f5(_0xf76e32, NULL);
      let _0x234bba = _0x3188fb.isNull() ? null : _0x3188fb.add(off2.itemObjType).readU8();
      return _0x27ee2b(true, true, true, _0x234bba);
    }
    return _0x27ee2b(true, true, false, null);
  }
  function _0x3e409b(_0x1c6bc3, _0x510d2e, _0x2d3333) {
    if (!_0x4c024d) {
      send({
        t: "recall",
        ok: false,
        error: "recall offsets not loaded"
      });
      return;
    }
    if (!_0x545f85) {
      send({
        t: "recall",
        ok: false,
        error: "bag offsets not loaded"
      });
      return;
    }
    if (!_0x149b3b(_0x1c6bc3, _0x510d2e, _0x2d3333)) {
      send({
        t: "recall",
        ok: false,
        error: "invalid recall arguments"
      });
      return;
    }
    if (_0x53c8d0.isNull()) {
      send({
        t: "recall",
        ok: false,
        error: "no server connection yet"
      });
      return;
    }
    let _0x24e3b1 = _0x1c6bc3;
    let _0x4ec37e = _0x510d2e;
    let _0xc7bed0 = _0x2d3333;
    if (!_0x5b8db7(() => {
      try {
        let _0x3b12bb = _0x5700eb(_0x24e3b1, _0x4ec37e, _0xc7bed0);
        if (_0x3b12bb !== null) {
          send({
            t: "recall",
            ok: false,
            error: _0x3b12bb
          });
          return;
        }
        _0x3f745b(_0x53c8d0, _0x24e3b1, NULL);
        _0x475d3e++;
        send({
          t: "recall",
          ok: true,
          seq: _0x475d3e
        });
      } catch (_0x3e8941) {
        send({
          t: "recall",
          ok: false,
          error: "" + _0x3e8941
        });
      }
    })) {
      send({
        t: "recall",
        ok: false,
        error: "frame queue unavailable"
      });
    }
  }
  function _0x4aaeb0(_0xbc5c7c, _0x58b8a4, _0x5a952d, _0x8a23c4) {
    if (!_0x528654) {
      send({
        t: "friend_warp",
        ok: false,
        error: "friend warp offsets not loaded"
      });
      return;
    }
    if (!_0x545f85) {
      send({
        t: "friend_warp",
        ok: false,
        error: "bag offsets not loaded"
      });
      return;
    }
    if (!_0x58f4ec) {
      send({
        t: "friend_warp",
        ok: false,
        error: "friend offsets not loaded"
      });
      return;
    }
    if (typeof _0xbc5c7c != "string" || _0xbc5c7c.length === 0) {
      send({
        t: "friend_warp",
        ok: false,
        error: "invalid friend name"
      });
      return;
    }
    if (!_0x149b3b(_0x58b8a4, _0x5a952d, _0x8a23c4)) {
      send({
        t: "friend_warp",
        ok: false,
        error: "invalid friend warp arguments"
      });
      return;
    }
    if (_0x53c8d0.isNull()) {
      send({
        t: "friend_warp",
        ok: false,
        error: "no server connection yet"
      });
      return;
    }
    let _0x208e63 = _0xbc5c7c;
    let _0x43f126 = _0x58b8a4;
    let _0x3078ba = _0x5a952d;
    let _0x258043 = _0x8a23c4;
    if (!_0x5b8db7(() => {
      try {
        let off2 = off;
        let _0x4f3494 = _0x35e499(off2.tiCharacterFriendManager, off2.sfFriendMgrInstance);
        if (_0x4f3494.isNull()) {
          send({
            t: "friend_warp",
            ok: false,
            error: "no friend manager yet"
          });
          return;
        }
        let fmFriendsPtr = _0x4f3494.add(off2.fmFriends).readPointer();
        let _0x5072fe = fmFriendsPtr.isNull() ? [] : _0x3da0da(fmFriendsPtr);
        let _0x52fd77 = -1;
        for (let _0x4b7af5 = 0; _0x4b7af5 < _0x5072fe.length; _0x4b7af5++) {
          if (_0x5072fe[_0x4b7af5].name === _0x208e63) {
            if (_0x52fd77 >= 0) {
              _0x52fd77 = -2;
              break;
            }
            _0x52fd77 = _0x4b7af5;
          }
        }
        if (_0x52fd77 === -1) {
          send({
            t: "friend_warp",
            ok: false,
            error: "friend not found: " + _0x208e63
          });
          return;
        }
        if (_0x52fd77 === -2) {
          send({
            t: "friend_warp",
            ok: false,
            error: "friend name is ambiguous: " + _0x208e63
          });
          return;
        }
        let _0x4bf7ed = _0x5072fe[_0x52fd77];
        if (_0x4bf7ed.flag === -1) {
          send({
            t: "friend_warp",
            ok: false,
            error: "friend is blocked: " + _0x208e63
          });
          return;
        }
        if (_0x4bf7ed.known && !_0x4bf7ed.online) {
          send({
            t: "friend_warp",
            ok: false,
            error: "friend is offline: " + _0x208e63
          });
          return;
        }
        let _0x544b98 = _0x5700eb(_0x43f126, _0x3078ba, _0x258043, true);
        if (_0x544b98 !== null) {
          send({
            t: "friend_warp",
            ok: false,
            error: _0x544b98
          });
          return;
        }
        let _0x19890e = _0xc5f073(Memory.allocUtf8String(_0x208e63));
        _0x24fb9b(_0x53c8d0, _0x19890e, _0x43f126, NULL);
        _0x27b05c++;
        send({
          t: "friend_warp",
          ok: true,
          seq: _0x27b05c
        });
      } catch (_0x190472) {
        send({
          t: "friend_warp",
          ok: false,
          error: "" + _0x190472
        });
      }
    })) {
      send({
        t: "friend_warp",
        ok: false,
        error: "frame queue unavailable"
      });
    }
  }
  function _0x27d064() {
    let off2 = off;
    let _0xeaa314 = _0xa44dd5(off2, KEYS_SKILL_TAB);
    if (_0xeaa314.length > 0) {
      _0x455844 = _0xeaa314;
      _0x18b634 = "offsets missing";
      return false;
    }
    _0x455844 = [];
    let _0x2cf008 = _0x3166d6(off2.rvaSwitchToTab, "SkillTabManager.SwitchToTab");
    if (typeof _0x2cf008 == "string") {
      _0x18b634 = _0x2cf008;
      return false;
    }
    let _0x4e9a30 = _0x524517(off2.tiSkillTabManager, "SkillTabManager TypeInfo");
    if (_0x4e9a30 !== null) {
      _0x18b634 = _0x4e9a30;
      return false;
    } else if (_0xfeda7a) {
      _0x590e9e = new NativeFunction(_0x2cf008, "void", ["pointer", "int", "pointer"]);
      _0x393129 = null;
      _0x18b634 = "";
      return true;
    } else {
      _0x18b634 = "the skill tier is not armed";
      return false;
    }
  }
  function _0xe913d1(_0x19b177, _0x263ac9, _0x5c08a3) {
    if (!_0x5f4082) {
      send({
        t: "buff_cast",
        slot: _0x19b177,
        result: "unavailable",
        why: _0x18b634
      });
      return;
    }
    if (_0x393129 !== null) {
      send({
        t: "buff_cast",
        slot: _0x19b177,
        result: "busy",
        why: "a buff_cast is already running"
      });
      return;
    }
    if (!(_0x19b177 >= 1) || !(_0x19b177 <= _0x24f684)) {
      send({
        t: "buff_cast",
        slot: _0x19b177,
        result: "error",
        why: "slot " + _0x19b177 + " is not 1..10"
      });
      return;
    }
    if (!_0x52d1d0) {
      send({
        t: "buff_cast",
        slot: _0x19b177,
        result: "busy",
        why: "no frame hook"
      });
      return;
    }
    _0x393129 = {
      slot: _0x19b177,
      main: _0x263ac9,
      sub: _0x5c08a3,
      started: false,
      back: -1,
      switched: false,
      code: -1,
      castMs: 0,
      castFrame: 0,
      sawBusy: false
    };
  }
  function _0xfaff3b() {
    let _0x5ec6c9 = _0x393129;
    if (_0x5ec6c9 !== null) {
      try {
        if (_0x5ec6c9.started) {
          _0x236abe(_0x5ec6c9);
        } else {
          _0x26a65a(_0x5ec6c9);
        }
      } catch (_0x36c521) {
        _0x521550(_0x5ec6c9, {
          t: "buff_cast",
          slot: _0x5ec6c9.slot,
          result: "error",
          why: "" + _0x36c521
        });
      }
    }
  }
  function _0x26a65a(_0x94a74e) {
    _0x94a74e.started = true;
    let off2 = off;
    if (_0x390ac2.isNull()) {
      _0x521550(_0x94a74e, {
        t: "buff_cast",
        slot: _0x94a74e.slot,
        result: "busy",
        why: "no player controller yet"
      });
      return;
    }
    if (_0x5e47fc.isNull()) {
      _0x521550(_0x94a74e, {
        t: "buff_cast",
        slot: _0x94a74e.slot,
        result: "busy",
        why: "no skill bar yet"
      });
      return;
    }
    let _0x427322 = _0x35e499(off2.tiSkillTabManager, off2.sfSkillTabInstance);
    if (_0x427322.isNull()) {
      _0x521550(_0x94a74e, {
        t: "buff_cast",
        slot: _0x94a74e.slot,
        result: "busy",
        why: "no SkillTabManager instance yet"
      });
      return;
    }
    let pcSkillDataPtr = _0x390ac2.add(off2.pcSkillData).readPointer();
    if (pcSkillDataPtr.isNull()) {
      _0x521550(_0x94a74e, {
        t: "buff_cast",
        slot: _0x94a74e.slot,
        result: "busy",
        why: "no skill data on the character"
      });
      return;
    }
    let pcCharLogicPtr = _0x390ac2.add(off2.pcCharLogic).readPointer();
    if (pcCharLogicPtr.isNull()) {
      _0x521550(_0x94a74e, {
        t: "buff_cast",
        slot: _0x94a74e.slot,
        result: "busy",
        why: "no character logic yet"
      });
      return;
    }
    if (_0x3f8a70(pcSkillDataPtr)) {
      _0x521550(_0x94a74e, {
        t: "buff_cast",
        slot: _0x94a74e.slot,
        result: "busy",
        why: "the character is busy"
      });
      return;
    }
    let _0xf8c032 = _0x39f35a(_0x5e47fc);
    if (_0xf8c032 === null) {
      _0x5e47fc = NULL;
      _0xf43ce = "";
      _0x521550(_0x94a74e, {
        t: "buff_cast",
        slot: _0x94a74e.slot,
        result: "busy",
        why: "the skill bar went away"
      });
      return;
    }
    _0x94a74e.back = _0x564b59();
    if (_0x94a74e.back < 1 || _0x94a74e.back > 3) {
      _0x521550(_0x94a74e, {
        t: "buff_cast",
        slot: _0x94a74e.slot,
        result: "busy",
        why: "no window number on the bar"
      });
      return;
    }
    if (_0x94a74e.back !== _0x2a2537 && (_0x94a74e.switched = true, _0x590e9e(_0x427322, _0x2a2537, NULL), _0xf8c032 = _0x39f35a(_0x5e47fc), _0xf8c032 === null)) {
      _0x5e47fc = NULL;
      _0xf43ce = "";
      _0x521550(_0x94a74e, {
        t: "buff_cast",
        slot: _0x94a74e.slot,
        result: "error",
        why: "the skill bar went away after the switch"
      });
      return;
    }
    let _0x23c851 = _0x4edbfa(_0xf8c032, _0x94a74e.slot);
    let _0x101284 = _0x23c851.isNull() ? NULL : _0x23c851.add(off2.ssSkill).readPointer();
    let _0x54044c = _0x101284.isNull() ? _0x87a098 : _0x101284.add(off2.skMainId).readU16();
    if (_0x54044c === _0x87a098) {
      _0x521550(_0x94a74e, {
        t: "buff_cast",
        slot: _0x94a74e.slot,
        result: "mismatch",
        why: "slot " + _0x94a74e.slot + " is empty"
      });
      return;
    }
    let skSubId = _0x101284.add(off2.skSubId).readU16();
    if (_0x54044c !== _0x94a74e.main || skSubId !== _0x94a74e.sub) {
      _0x521550(_0x94a74e, {
        t: "buff_cast",
        slot: _0x94a74e.slot,
        result: "mismatch",
        why: "slot " + _0x94a74e.slot + " holds " + _0x54044c + ":" + skSubId + ", not " + _0x94a74e.main + ":" + _0x94a74e.sub
      });
      return;
    }
    _0x3bbe00.writeU16(_0x54044c);
    _0x3bbe00.add(2).writeU16(skSubId);
    let _0x1af050 = _0x394502(pcCharLogicPtr, _0x3bbe00, 1, 0, NULL);
    if (_0x1af050 !== 0) {
      _0x521550(_0x94a74e, {
        t: "buff_cast",
        slot: _0x94a74e.slot,
        result: "not_ready",
        code: _0x1af050
      });
      return;
    }
    let _0x1aa92e = _0x4b666c(pcSkillDataPtr, _0x23c851, NULL);
    if (_0x1aa92e !== _0x2c5b60 && _0x1aa92e !== _0x908c94) {
      _0x521550(_0x94a74e, {
        t: "buff_cast",
        slot: _0x94a74e.slot,
        result: "invalid",
        code: _0x1aa92e
      });
      return;
    }
    _0x94a74e.code = _0x1aa92e;
    _0x94a74e.castMs = Date.now();
    _0x94a74e.castFrame = _0x5dc799;
    _0x236abe(_0x94a74e);
  }
  function _0x3f8a70(_0x35e302) {
    let off2 = off;
    if (_0x390ac2.add(off2.pcAction).readU8() === _0x442a67 || _0x390ac2.add(off2.pcCastPending).readU8() !== 0) {
      return true;
    } else if (_0x35e302.isNull()) {
      return false;
    } else {
      return _0x35e302.add(off2.sdToMove).readU8() !== 0;
    }
  }
  function _0x236abe(_0x50b4f7) {
    let off2 = off;
    let pcSkillDataPtr = _0x390ac2.add(off2.pcSkillData).readPointer();
    let _0x3a125d = _0x3f8a70(pcSkillDataPtr);
    if (_0x3a125d) {
      _0x50b4f7.sawBusy = true;
    }
    let _0x47f81a = Date.now() - _0x50b4f7.castMs;
    let _0x26fa89 = _0x50b4f7.code === _0x908c94 ? "move" : "ok";
    if (!_0x3a125d && (_0x50b4f7.sawBusy || _0x5dc799 - _0x50b4f7.castFrame >= _0xec09a8)) {
      _0x521550(_0x50b4f7, {
        t: "buff_cast",
        slot: _0x50b4f7.slot,
        result: _0x26fa89,
        code: _0x50b4f7.code,
        settle_ms: _0x47f81a,
        timed_out: false
      });
      return;
    }
    if (_0x47f81a >= _0x3b935a) {
      _0x521550(_0x50b4f7, {
        t: "buff_cast",
        slot: _0x50b4f7.slot,
        result: _0x26fa89,
        code: _0x50b4f7.code,
        settle_ms: _0x47f81a,
        timed_out: true
      });
    }
  }
  function _0x521550(_0x13c987, _0x509d3c) {
    if (_0x393129 === _0x13c987) {
      _0x393129 = null;
    }
    if (_0x13c987.switched) {
      _0x13c987.switched = false;
      let _0x1b31b0 = _0x358477(_0x13c987.back);
      if (_0x1b31b0 !== "") {
        _0x509d3c = {
          t: "buff_cast",
          slot: _0x13c987.slot,
          result: "error",
          why: "switch back to window " + _0x13c987.back + " failed: " + _0x1b31b0
        };
      }
    }
    send(_0x509d3c);
  }
  function _0x358477(_0x2088dd) {
    try {
      let off2 = off;
      let _0x4a9f45 = _0x35e499(off2.tiSkillTabManager, off2.sfSkillTabInstance);
      if (_0x4a9f45.isNull()) {
        return "no SkillTabManager instance";
      }
      _0x590e9e(_0x4a9f45, _0x2088dd, NULL);
      let _0x33dfc0 = _0x564b59();
      if (_0x33dfc0 !== _0x2088dd) {
        return "the bar still shows window " + _0x33dfc0;
      } else {
        return "";
      }
    } catch (_0x3b0e6a) {
      return "" + _0x3b0e6a;
    }
  }
  function _0x5e57c8() {
    let off2 = off;
    let _0x1bb53a = _0xa44dd5(off2, KEYS_SKILL);
    if (_0x1bb53a.length > 0) {
      _0x21193b = _0x1bb53a;
      _0x11dcc0 = "offsets missing";
      return false;
    }
    _0x21193b = [];
    let _0x333449 = [{
      rva: off2.rvaSkillBarAnchor,
      what: "UserInterfaceSkill.Update"
    }, {
      rva: off2.rvaSkillCast,
      what: "SkillData.DoCastSkill"
    }, {
      rva: off2.rvaSkillCheck,
      what: "GameCharLogic.CHECKSKILL"
    }, {
      rva: off2.rvaSkillGetObject,
      what: "SkillSlot.GetSkillObject"
    }];
    for (let _0x306dfc of _0x333449) {
      let _0x3eb440 = _0x3166d6(_0x306dfc.rva, _0x306dfc.what);
      if (typeof _0x3eb440 == "string") {
        _0x11dcc0 = _0x3eb440;
        return false;
      }
    }
    _0x4b666c = new NativeFunction(_0x9ca124.add(off2.rvaSkillCast), "int", ["pointer", "pointer", "pointer"]);
    _0x394502 = new NativeFunction(_0x9ca124.add(off2.rvaSkillCheck), "uint16", ["pointer", "pointer", "uint16", "uint8", "pointer"]);
    _0x4ce11e = new NativeFunction(_0x9ca124.add(off2.rvaSkillGetObject), "pointer", ["pointer", "pointer"]);
    if (_0x3bbe00.isNull()) {
      _0x3bbe00 = Memory.alloc(4);
    }
    _0x4b1dc0();
    _0x1467f2 = Interceptor.attach(_0x9ca124.add(off2.rvaSkillBarAnchor), {
      onEnter(args) {
        if (_0x5e47fc.isNull()) {
          try {
            if (_0x39f35a(args[0]) === null) {
              return;
            }
            _0x5e47fc = args[0];
          } catch {}
        }
      }
    });
    _0x11dcc0 = "";
    return true;
  }
  function _0x4b1dc0() {
    if (_0x1467f2 !== null) {
      _0x1467f2.detach();
      _0x1467f2 = null;
    }
  }
  function _0x39f35a(_0x3ec026) {
    let off2 = off;
    if (_0x3ec026.isNull()) {
      return null;
    }
    let uisSkillWindowPtr = _0x3ec026.add(off2.uisSkillWindow).readPointer();
    if (uisSkillWindowPtr.isNull()) {
      return null;
    }
    let swoContainerPtr = uisSkillWindowPtr.add(off2.swoContainer).readPointer();
    if (swoContainerPtr.isNull()) {
      return null;
    }
    let swSlotsPtr = swoContainerPtr.add(off2.swSlots).readPointer();
    if (swSlotsPtr.isNull()) {
      return null;
    } else if (swSlotsPtr.add(off2.arrCount).readU32() === _0x24f684) {
      return swSlotsPtr;
    } else {
      return null;
    }
  }
  function _0x564b59() {
    if (!_0xfeda7a || _0x5e47fc.isNull()) {
      return -1;
    }
    let off2 = off;
    try {
      let uisSkillWindowPtr = _0x5e47fc.add(off2.uisSkillWindow).readPointer();
      if (uisSkillWindowPtr.isNull()) {
        return -1;
      } else {
        return uisSkillWindowPtr.add(off2.swoTabIndex).readS32();
      }
    } catch {
      return -1;
    }
  }
  function _0x4f66ff(_0x1f7bf5) {
    let _0x28378a = "";
    for (let _0x4ce35a of _0x1f7bf5) {
      _0x28378a += _0x4ce35a[0] + ":" + _0x4ce35a[1] + ",";
    }
    return _0x28378a;
  }
  function _0x4edbfa(_0xbf87c1, _0x42c97e) {
    let off2 = off;
    if (_0x42c97e >= 1 && _0x42c97e <= _0x24f684) {
      return _0xbf87c1.add(off2.arrFirst + (_0x42c97e - 1) * off2.arrStride).readPointer();
    } else {
      return NULL;
    }
  }
  function _0x5d268f(_0x162983) {
    if (!_0xfeda7a) {
      send({
        t: "skill",
        ok: false,
        fired: 0,
        casts: [],
        error: "skill offsets not loaded"
      });
      return;
    }
    if (_0x162983.length === 0) {
      send({
        t: "skill",
        ok: false,
        fired: 0,
        casts: [],
        error: "no slots asked for"
      });
      return;
    }
    if (_0x390ac2.isNull()) {
      send({
        t: "skill",
        ok: false,
        fired: 0,
        casts: [],
        error: "no player controller yet"
      });
      return;
    }
    if (_0x5e47fc.isNull()) {
      send({
        t: "skill",
        ok: false,
        fired: 0,
        casts: [],
        error: "no skill bar yet"
      });
      return;
    }
    let off2 = off;
    if (!_0x5b8db7(() => {
      try {
        if (_0x393129 !== null && _0x393129.switched) {
          send({
            t: "skill",
            ok: false,
            fired: 0,
            casts: [],
            error: "a buff_cast holds the bar"
          });
          return;
        }
        let pcSkillDataPtr = _0x390ac2.add(off2.pcSkillData).readPointer();
        if (pcSkillDataPtr.isNull()) {
          send({
            t: "skill",
            ok: false,
            fired: 0,
            casts: [],
            error: "no skill data on the character"
          });
          return;
        }
        let _0x329ec0 = _0x39f35a(_0x5e47fc);
        if (_0x329ec0 === null) {
          _0x5e47fc = NULL;
          _0xf43ce = "";
          send({
            t: "skill",
            ok: false,
            fired: 0,
            casts: [],
            error: "the skill bar went away"
          });
          return;
        }
        let _0x1d1f87 = [];
        let _0x4a583b = 0;
        for (let _0x2db5d3 of _0x162983) {
          let _0x2788bb = _0x4edbfa(_0x329ec0, _0x2db5d3);
          if (_0x2788bb.isNull()) {
            _0x1d1f87.push([_0x2db5d3, _0x3e1997]);
            continue;
          }
          let _0x18b448 = _0x4b666c(pcSkillDataPtr, _0x2788bb, NULL);
          _0x1d1f87.push([_0x2db5d3, _0x18b448]);
          if (_0x18b448 === 0) {
            _0x4a583b = _0x2db5d3;
            break;
          }
        }
        if (_0x4a583b !== 0) {
          _0xf43ce = "";
          send({
            t: "skill",
            ok: true,
            fired: _0x4a583b,
            casts: _0x1d1f87
          });
          return;
        }
        let _0x229105 = _0x4f66ff(_0x1d1f87);
        if (_0x229105 === _0xf43ce) {
          send({
            t: "skill",
            ok: false,
            fired: 0,
            casts: _0x1d1f87
          });
          return;
        }
        _0xf43ce = _0x229105;
        send({
          t: "skill",
          ok: false,
          fired: 0,
          casts: _0x1d1f87,
          why: _0x131915(_0x329ec0, _0x1d1f87)
        });
      } catch (_0xd6013e) {
        send({
          t: "skill",
          ok: false,
          fired: 0,
          casts: [],
          error: "" + _0xd6013e
        });
      }
    })) {
      send({
        t: "skill",
        ok: false,
        fired: 0,
        casts: [],
        error: "frame queue unavailable"
      });
    }
  }
  function _0x131915(_0x10d223, _0x4c4b67) {
    let off2 = off;
    let _0x4ffdae = [];
    let pcCharLogicPtr = _0x390ac2.add(off2.pcCharLogic).readPointer();
    if (pcCharLogicPtr.isNull()) {
      return _0x4ffdae;
    }
    for (let _0x244a0e of _0x4c4b67) {
      if (_0x244a0e[1] === _0x3e1997) {
        continue;
      }
      let _0x4088d3 = _0x4edbfa(_0x10d223, _0x244a0e[0]);
      if (_0x4088d3.isNull()) {
        continue;
      }
      let ssSkillPtr = _0x4088d3.add(off2.ssSkill).readPointer();
      if (!ssSkillPtr.isNull()) {
        _0x3bbe00.writeU16(ssSkillPtr.add(off2.skMainId).readU16());
        _0x3bbe00.add(2).writeU16(ssSkillPtr.add(off2.skSubId).readU16());
        _0x4ffdae.push([_0x244a0e[0], _0x394502(pcCharLogicPtr, _0x3bbe00, 1, 0, NULL)]);
      }
    }
    return _0x4ffdae;
  }
  function _0x456a04() {
    if (!_0xfeda7a) {
      send({
        t: "skill_bar",
        ok: false,
        error: "skill offsets not loaded"
      });
      return;
    }
    if (_0x5e47fc.isNull()) {
      send({
        t: "skill_bar",
        ok: false,
        error: "no skill bar yet"
      });
      return;
    }
    let off2 = off;
    if (!_0x5b8db7(() => {
      try {
        let _0x5b1911 = _0x39f35a(_0x5e47fc);
        if (_0x5b1911 === null) {
          _0x5e47fc = NULL;
          _0xf43ce = "";
          send({
            t: "skill_bar",
            ok: false,
            error: "the skill bar went away"
          });
          return;
        }
        let _0xb36d6 = _0x564b59();
        let _0x59275d = [];
        for (let _0x1fc759 = 1; _0x1fc759 <= _0x24f684; _0x1fc759++) {
          let _0x42be83 = _0x4edbfa(_0x5b1911, _0x1fc759);
          if (_0x42be83.isNull()) {
            _0x59275d.push({
              n: _0x1fc759,
              name: "",
              main: 0,
              sub: 0
            });
            continue;
          }
          let ssSkillPtr = _0x42be83.add(off2.ssSkill).readPointer();
          if (ssSkillPtr.isNull()) {
            _0x59275d.push({
              n: _0x1fc759,
              name: "",
              main: 0,
              sub: 0
            });
            continue;
          }
          let _0x30ff8b = _0x4ce11e(_0x42be83, NULL);
          _0x59275d.push({
            n: _0x1fc759,
            name: _0x30ff8b.isNull() ? "" : _0x2df1c6(_0x30ff8b, off2.sbName),
            main: ssSkillPtr.add(off2.skMainId).readU16(),
            sub: ssSkillPtr.add(off2.skSubId).readU16()
          });
        }
        send({
          t: "skill_bar",
          ok: true,
          set: _0xb36d6,
          slots: _0x59275d
        });
      } catch (_0x194c71) {
        send({
          t: "skill_bar",
          ok: false,
          error: "" + _0x194c71
        });
      }
    })) {
      send({
        t: "skill_bar",
        ok: false,
        error: "frame queue unavailable"
      });
    }
  }
  function _0x1c3c82(_0x103e87) {
    if (!_0xfeda7a) {
      send({
        t: "skill_check",
        ok: false,
        slots: []
      });
      return;
    }
    if (_0x5e47fc.isNull()) {
      send({
        t: "skill_check",
        ok: false,
        slots: []
      });
      return;
    }
    let off2 = off;
    if (!_0x5b8db7(() => {
      try {
        let pcCharLogicPtr = _0x390ac2.add(off2.pcCharLogic).readPointer();
        let _0x410587 = _0x39f35a(_0x5e47fc);
        if (pcCharLogicPtr.isNull() || _0x410587 === null) {
          send({
            t: "skill_check",
            ok: false,
            slots: []
          });
          return;
        }
        let _0x461f8d = [];
        for (let _0x4e8be2 of _0x103e87) {
          let _0x2eb31c = _0x4edbfa(_0x410587, _0x4e8be2);
          if (_0x2eb31c.isNull()) {
            _0x461f8d.push({
              n: _0x4e8be2,
              code: -1,
              ready: false
            });
            continue;
          }
          let ssSkillPtr = _0x2eb31c.add(off2.ssSkill).readPointer();
          if (ssSkillPtr.isNull()) {
            _0x461f8d.push({
              n: _0x4e8be2,
              code: -1,
              ready: false
            });
            continue;
          }
          let skMainId = ssSkillPtr.add(off2.skMainId).readU16();
          if (skMainId === 65535) {
            _0x461f8d.push({
              n: _0x4e8be2,
              code: -1,
              ready: false
            });
            continue;
          }
          _0x3bbe00.writeU16(skMainId);
          _0x3bbe00.add(2).writeU16(ssSkillPtr.add(off2.skSubId).readU16());
          let _0x171630 = _0x394502(pcCharLogicPtr, _0x3bbe00, 1, 0, NULL);
          _0x461f8d.push({
            n: _0x4e8be2,
            code: _0x171630,
            ready: _0x171630 === 0
          });
        }
        send({
          t: "skill_check",
          ok: true,
          slots: _0x461f8d
        });
      } catch {
        send({
          t: "skill_check",
          ok: false,
          slots: []
        });
      }
    })) {
      send({
        t: "skill_check",
        ok: false,
        slots: []
      });
    }
  }
  function _0x229c2f(_0x243358) {
    if (!_0xfeda7a) {
      send({
        t: "skill_ready",
        ok: false,
        reason: "skill offsets not loaded"
      });
      return;
    }
    let off2 = off;
    let _0x301661 = _0x243358.slice(0, _0x448e55);
    if (!_0x5b8db7(() => {
      try {
        if (_0x390ac2.isNull()) {
          send({
            t: "skill_ready",
            ok: false,
            reason: "no player controller yet"
          });
          return;
        }
        let pcCharLogicPtr = _0x390ac2.add(off2.pcCharLogic).readPointer();
        if (pcCharLogicPtr.isNull()) {
          send({
            t: "skill_ready",
            ok: false,
            reason: "no character logic yet"
          });
          return;
        }
        let _0x2b302c = [];
        for (let _0x1ce4b6 of _0x301661) {
          let _0x2d6894 = Array.isArray(_0x1ce4b6) ? _0x1ce4b6[0] : -1;
          let _0x348398 = Array.isArray(_0x1ce4b6) ? _0x1ce4b6[1] : -1;
          if (!_0x196649(_0x2d6894) || !_0x196649(_0x348398)) {
            _0x2b302c.push({
              main: _0x2d6894,
              sub: _0x348398,
              code: -1
            });
            continue;
          }
          try {
            _0x3bbe00.writeU16(_0x2d6894);
            _0x3bbe00.add(2).writeU16(_0x348398);
            _0x2b302c.push({
              main: _0x2d6894,
              sub: _0x348398,
              code: _0x394502(pcCharLogicPtr, _0x3bbe00, 1, 0, NULL)
            });
          } catch {
            _0x2b302c.push({
              main: _0x2d6894,
              sub: _0x348398,
              code: -1
            });
          }
        }
        send({
          t: "skill_ready",
          ok: true,
          ids: _0x2b302c
        });
      } catch (_0xda5cbb) {
        send({
          t: "skill_ready",
          ok: false,
          reason: "" + _0xda5cbb
        });
      }
    })) {
      send({
        t: "skill_ready",
        ok: false,
        reason: "frame queue unavailable"
      });
    }
  }
  function _0x196649(_0x761ebc) {
    return typeof _0x761ebc == "number" && Number.isInteger(_0x761ebc) && _0x761ebc >= 0 && _0x761ebc <= 65535;
  }
  function _0x269cab() {
    let off2 = off;
    let _0x53fb16 = _0xa44dd5(off2, KEYS_WORLD_TO_SCREEN);
    if (_0x53fb16.length > 0) {
      _0x54bde4 = _0x53fb16;
      return false;
    } else {
      _0x54bde4 = [];
      _0x4be5bd = new NativeFunction(_0x9ca124.add(off2.rvaCameraMain), "pointer", ["pointer"]);
      _0x242066 = new NativeFunction(_0x9ca124.add(off2.rvaScreenWidth), "int", ["pointer"]);
      _0x402cd6 = new NativeFunction(_0x9ca124.add(off2.rvaScreenHeight), "int", ["pointer"]);
      _0x449d2d = new NativeFunction(_0x9ca124.add(off2.rvaW2sPoint), "void", ["pointer", "pointer", "int", "pointer", "pointer"]);
      return true;
    }
  }
  function _0x21920e(_0x42fd26) {
    let off2 = off;
    if (off2 === null || !off2.objCachedPtr || _0x42fd26.isNull()) {
      return NULL;
    } else {
      return _0x42fd26.add(off2.objCachedPtr).readPointer();
    }
  }
  function _0x3a58ba(_0x7e0323) {
    if (_0x7e0323.isNull()) {
      return false;
    }
    let off2 = off;
    if (off2 === null) {
      return false;
    } else if (off2.objCachedPtr) {
      return !_0x7e0323.add(off2.objCachedPtr).readPointer().isNull();
    } else {
      return true;
    }
  }
  function _0x257f0c() {
    _0x3cb965 = NULL;
    _0xbfec86 = NULL;
    _0x95429a = 0;
    _0xb637ed = 0;
  }
  function _0x314e1d() {
    if (!_0x43c9d6 || _0x4be5bd === null || _0x242066 === null || _0x402cd6 === null) {
      return false;
    }
    let off2 = off;
    if (!_0x3cb965.isNull() && _0x3a58ba(_0x3cb965)) {
      return true;
    }
    _0x257f0c();
    let _0x3dd547 = _0x4be5bd(NULL);
    if (_0x3dd547.isNull()) {
      return false;
    }
    let objCachedPtrPtr = _0x3dd547.add(off2.objCachedPtr).readPointer();
    if (objCachedPtrPtr.isNull()) {
      return false;
    } else {
      _0x3cb965 = _0x3dd547;
      _0xbfec86 = objCachedPtrPtr;
      _0x95429a = _0x242066(NULL);
      _0xb637ed = _0x402cd6(NULL);
      return true;
    }
  }
  function _0x1f16d9(_0x21af8f, _0x3bfb64, _0x5e2149) {
    if (!_0x43c9d6 || _0x449d2d === null || _0xbfec86.isNull()) {
      return null;
    }
    let off2 = off;
    let _0x3d0410 = Memory.alloc(12);
    let _0x4b4487 = Memory.alloc(12);
    _0x3d0410.writeFloat(_0x21af8f);
    _0x3d0410.add(4).writeFloat(_0x3bfb64);
    _0x3d0410.add(8).writeFloat(_0x5e2149);
    _0x449d2d(_0xbfec86, _0x3d0410, off2.eyeMono, _0x4b4487, NULL);
    let _0x79e756 = _0x4b4487.add(8).readFloat();
    if (_0x79e756 <= 0) {
      return null;
    }
    let _0xd52735 = _0x4b4487.readFloat();
    let _0x51e6cc = _0xb637ed - _0x4b4487.add(4).readFloat();
    return [_0xd52735, _0x51e6cc, _0x79e756];
  }
  var _0x4b8715 = 64;
  var _0x34a399 = 0.15;
  function _0x28f3af(_0x5e1d99, _0x269241, _0x624c06, _0x266972, _0x20dcd1, _0x22ec95, _0x2bfa8f) {
    if (_0x2e9b66 === null || _0xc1f0b3 === null || _0x9c1407 === null || _0x50671e === null || _0x3f4ff3 === null || _0x2522df === null) {
      return 0;
    }
    let off2 = off;
    let _0x31522f = _0x269241.length;
    let _0x382c20 = _0x624c06.length;
    let _0x25a6ee = _0x4467b3();
    if (_0x25a6ee.isNull()) {
      return 0;
    }
    let _0x1bd3c1 = Memory.allocUtf8String("UnityEngine.CoreModule");
    let _0x936562 = _0x23b312(_0x25a6ee, _0x1bd3c1);
    if (_0x936562.isNull()) {
      return 0;
    }
    let _0x27d063 = _0x3565c8(_0x936562);
    if (_0x27d063.isNull()) {
      return 0;
    }
    let _0x5b8890 = Memory.allocUtf8String("UnityEngine");
    let _0x57ec6b = Memory.allocUtf8String("Vector3");
    let _0x10e473 = Memory.allocUtf8String("Color");
    let _0x3db988 = _0x214aab(_0x27d063, _0x5b8890, _0x57ec6b);
    let _0x594b90 = _0x214aab(_0x27d063, _0x5b8890, _0x10e473);
    if (_0x3db988.isNull() || _0x594b90.isNull()) {
      return 0;
    }
    let _0x5084d2 = Memory.allocUtf8String("mscorlib");
    let _0x3917c3 = _0x23b312(_0x25a6ee, _0x5084d2);
    if (_0x3917c3.isNull()) {
      return 0;
    }
    let _0x4e1783 = _0x3565c8(_0x3917c3);
    let _0x766124 = Memory.allocUtf8String("System");
    let _0x1cb562 = Memory.allocUtf8String("Int32");
    let _0x5a0479 = _0x214aab(_0x4e1783, _0x766124, _0x1cb562);
    if (_0x5a0479.isNull()) {
      return 0;
    }
    let _0xd715fc = _0x2e9b66(_0x3db988, _0x31522f);
    let _0xb8355d = _0x2e9b66(_0x5a0479, _0x382c20);
    let _0xf498b7 = _0x2e9b66(_0x594b90, _0x31522f);
    if (_0xd715fc.isNull() || _0xb8355d.isNull() || _0xf498b7.isNull()) {
      return 0;
    }
    _0xc1f0b3(_0xd715fc, 0);
    _0xc1f0b3(_0xb8355d, 0);
    _0xc1f0b3(_0xf498b7, 0);
    let arrFirstAddr = _0xd715fc.add(off2.arrFirst);
    for (let _0x25b8fa = 0; _0x25b8fa < _0x31522f; _0x25b8fa++) {
      let _0x11ed5f = off2.strideV3 * _0x25b8fa;
      arrFirstAddr.add(_0x11ed5f).writeFloat(_0x269241[_0x25b8fa][0]);
      arrFirstAddr.add(_0x11ed5f + 4).writeFloat(_0x269241[_0x25b8fa][1]);
      arrFirstAddr.add(_0x11ed5f + 8).writeFloat(_0x269241[_0x25b8fa][2]);
    }
    let arrFirstAddr2 = _0xb8355d.add(off2.arrFirst);
    for (let _0x4aedff = 0; _0x4aedff < _0x382c20; _0x4aedff++) {
      arrFirstAddr2.add(_0x4aedff * off2.strideInt).writeS32(_0x624c06[_0x4aedff]);
    }
    let arrFirstAddr3 = _0xf498b7.add(off2.arrFirst);
    for (let _0x33213b = 0; _0x33213b < _0x31522f; _0x33213b++) {
      let _0x527836 = off2.strideColor * _0x33213b;
      arrFirstAddr3.add(_0x527836).writeFloat(_0x266972);
      arrFirstAddr3.add(_0x527836 + 4).writeFloat(_0x20dcd1);
      arrFirstAddr3.add(_0x527836 + 8).writeFloat(_0x22ec95);
      arrFirstAddr3.add(_0x527836 + 12).writeFloat(_0x2bfa8f);
    }
    _0x9c1407(_0x5e1d99, _0xd715fc, NULL);
    _0x50671e(_0x5e1d99, _0xb8355d, NULL);
    _0x3f4ff3(_0x5e1d99, _0xf498b7, NULL);
    return _0x2522df(_0x5e1d99, NULL);
  }
  function _0x1e53fe(_0x5ea9e5, _0x2fad62, _0x30f201, _0x3f044c, _0x70b0da, _0x5972d8) {
    let _0x47c5c9 = _0x4b8715;
    let _0x1bbcca = [[0, 0, 0]];
    let _0x327961 = [];
    for (let _0x164dbf = 0; _0x164dbf < _0x47c5c9; _0x164dbf++) {
      let _0x178894 = _0x164dbf / _0x47c5c9 * 2 * Math.PI;
      _0x1bbcca.push([Math.cos(_0x178894) * _0x2fad62, 0, Math.sin(_0x178894) * _0x2fad62]);
    }
    for (let _0x8f4292 = 0; _0x8f4292 < _0x47c5c9; _0x8f4292++) {
      let _0x5860ae = 1 + _0x8f4292;
      let _0xbc6323 = 1 + (_0x8f4292 + 1) % _0x47c5c9;
      _0x327961.push(0, _0x5860ae, _0xbc6323);
      _0x327961.push(0, _0xbc6323, _0x5860ae);
    }
    return _0x28f3af(_0x5ea9e5, _0x1bbcca, _0x327961, _0x30f201, _0x3f044c, _0x70b0da, _0x5972d8);
  }
  function _0x24164f(_0x4c4402, _0x9eb8eb, _0x3b9527, _0x46c79b, _0x7d63b1, _0x702005, _0x2b9b5a, _0x517a54, _0x21e310) {
    let _0x27c912 = Math.sqrt(_0x9eb8eb * _0x9eb8eb + _0x46c79b * _0x46c79b);
    let _0x514493 = _0x27c912 > 0 ? _0x9eb8eb / _0x27c912 : 0;
    let _0x5f344a = -(_0x27c912 > 0 ? _0x46c79b / _0x27c912 : 0) * (_0x7d63b1 / 2);
    let _0x266cc9 = _0x514493 * (_0x7d63b1 / 2);
    let _0x183bed = [[_0x5f344a, 0, _0x266cc9], [-_0x5f344a, 0, -_0x266cc9], [_0x9eb8eb + _0x5f344a, _0x3b9527, _0x46c79b + _0x266cc9], [_0x9eb8eb - _0x5f344a, _0x3b9527, _0x46c79b - _0x266cc9]];
    return _0x28f3af(_0x4c4402, _0x183bed, [0, 1, 2, 2, 1, 3, 0, 2, 1, 2, 3, 1], _0x702005, _0x2b9b5a, _0x517a54, _0x21e310);
  }
  function _0x4bbf43() {
    if (!_0x3f6352.isNull() && _0x3a58ba(_0x3f6352)) {
      return _0x3f6352;
    }
    if (_0x1975a5 === null || _0x334efa === null || _0x4d4f06 === null || _0xc1f0b3 === null || _0x214aab === null || _0x4467b3 === null || _0x23b312 === null || _0x3565c8 === null) {
      return NULL;
    }
    let _0x413736 = false;
    let _0x5d823a = NULL;
    if (_0x569b58) {
      let _0x154019 = _0xc5f073(Memory.allocUtf8String("Hidden/Internal-Colored"));
      if (!_0x154019.isNull()) {
        _0x5d823a = _0x1975a5(_0x154019, NULL);
      }
      _0x413736 = !_0x5d823a.isNull();
      _0x13ee08("ensureSharedMaterial: Hidden/Internal-Colored null=" + !_0x413736);
    }
    if (!_0x413736) {
      let _0x43a207 = Memory.allocUtf8String("Sprites/Default");
      let _0xc51779 = _0xc5f073(_0x43a207);
      if (_0xc51779.isNull() || (_0x5d823a = _0x1975a5(_0xc51779, NULL), _0x5d823a.isNull())) {
        return NULL;
      }
    }
    let _0x569a6e = _0x4467b3();
    let _0xb7acde = Memory.allocUtf8String("UnityEngine.CoreModule");
    let _0x7578ba = _0x23b312(_0x569a6e, _0xb7acde);
    if (_0x7578ba.isNull()) {
      return NULL;
    }
    let _0x4396d1 = _0x3565c8(_0x7578ba);
    let _0x167d79 = Memory.allocUtf8String("UnityEngine");
    let _0x28cb22 = Memory.allocUtf8String("Material");
    let _0x4bb05b = _0x214aab(_0x4396d1, _0x167d79, _0x28cb22);
    if (_0x4bb05b.isNull()) {
      return NULL;
    }
    let _0x51b0 = _0x4d4f06(_0x4bb05b);
    if (_0x51b0.isNull()) {
      return NULL;
    } else {
      _0x334efa(_0x51b0, _0x5d823a, NULL);
      _0xc1f0b3(_0x51b0, 0);
      if (_0x413736) {
        _0x5d88ea(_0x51b0);
      }
      _0x3f6352 = _0x51b0;
      _0x548f62 = _0x413736;
      return _0x51b0;
    }
  }
  function _0x5d88ea(_0x27a2fe) {
    let _0x3c5a1d = _0x43e1e6;
    _0x3c5a1d(_0x27a2fe, _0xc5f073(Memory.allocUtf8String("_ZTest")), 8, NULL);
    _0x3c5a1d(_0x27a2fe, _0xc5f073(Memory.allocUtf8String("_ZWrite")), 0, NULL);
    _0x3c5a1d(_0x27a2fe, _0xc5f073(Memory.allocUtf8String("_SrcBlend")), 5, NULL);
    _0x3c5a1d(_0x27a2fe, _0xc5f073(Memory.allocUtf8String("_DstBlend")), 10, NULL);
    _0x351656(_0x27a2fe, 4000, NULL);
  }
  function _0x10e375() {
    if (!_0x5788d6.isNull() && !_0x5749bd.isNull()) {
      return true;
    } else {
      _0x5788d6 = _0x486d4b("UnityEngine.CoreModule", "UnityEngine", "MeshFilter");
      _0x5749bd = _0x486d4b("UnityEngine.CoreModule", "UnityEngine", "MeshRenderer");
      return !_0x5788d6.isNull() && !_0x5749bd.isNull();
    }
  }
  function _0x2bc2e2(_0x4a29f4, _0x9048a9, _0x44a7b3, _0x149931, _0x59df25) {
    if (!_0x44669c) {
      return "zone offsets not loaded";
    }
    if (_0x390ac2.isNull()) {
      return "no character yet";
    }
    _0x13ee08("createZone: begin id=" + _0x4a29f4 + " radius=" + _0x9048a9);
    if (!_0x10e375()) {
      return "failed to get type objects";
    }
    _0x13ee08("createZone: type objects ok");
    let _0x894aed = off;
    let _0x158e04 = _0x4467b3();
    let _0x38c347 = Memory.allocUtf8String("UnityEngine.CoreModule");
    let _0x28af3d = _0x23b312(_0x158e04, _0x38c347);
    if (_0x28af3d.isNull()) {
      return "failed to open assembly";
    }
    let _0x320627 = _0x3565c8(_0x28af3d);
    let _0x15cf13 = Memory.allocUtf8String("UnityEngine");
    let _0x5a94f5 = Memory.allocUtf8String("GameObject");
    let _0x220b9e = _0x214aab(_0x320627, _0x15cf13, _0x5a94f5);
    if (_0x220b9e.isNull()) {
      return "failed to find GameObject class";
    }
    _0x13ee08("createZone: GameObject class ok");
    let _0x3e15fe = _0x4d4f06(_0x220b9e);
    if (_0x3e15fe.isNull()) {
      return "failed to create GameObject";
    }
    let _0x2160ff = _0xc5f073(Memory.allocUtf8String("Zone_" + _0x4a29f4));
    _0x13ee08("createZone: -> GameObject..ctor(string)");
    _0x3ecfea(_0x3e15fe, _0x2160ff, NULL);
    _0x13ee08("createZone: <- GameObject..ctor");
    _0xc1f0b3(_0x3e15fe, 0);
    _0x13ee08("createZone: -> AddComponent(MeshFilter)");
    let _0x1ca111 = _0x1c5718(_0x3e15fe, _0x5788d6, NULL);
    _0x13ee08("createZone: -> AddComponent(MeshRenderer)");
    let _0x41dd9e = _0x1c5718(_0x3e15fe, _0x5749bd, NULL);
    if (_0x1ca111.isNull() || _0x41dd9e.isNull()) {
      return "failed to add components";
    }
    let _0x2f55f4 = Memory.allocUtf8String("Mesh");
    let _0x322fa8 = _0x214aab(_0x320627, _0x15cf13, _0x2f55f4);
    if (_0x322fa8.isNull()) {
      return "failed to find Mesh class";
    }
    let _0x473139 = _0x4d4f06(_0x322fa8);
    if (_0x473139.isNull()) {
      return "failed to create Mesh";
    }
    _0x13ee08("createZone: -> Mesh..ctor");
    _0x32ddda(_0x473139, NULL);
    _0x13ee08("createZone: <- Mesh..ctor");
    _0xc1f0b3(_0x473139, 0);
    _0x13ee08("createZone: -> build mesh line=" + (_0x59df25 ? "yes" : "no"));
    if (_0x59df25) {
      _0x24164f(_0x473139, _0x59df25[0], _0x59df25[1], _0x59df25[2], _0x59df25[3], _0x44a7b3[0], _0x44a7b3[1], _0x44a7b3[2], _0x44a7b3[3]);
    } else {
      _0x1e53fe(_0x473139, _0x9048a9, _0x44a7b3[0], _0x44a7b3[1], _0x44a7b3[2], _0x44a7b3[3]);
    }
    _0x13ee08("createZone: <- build mesh");
    _0x13ee08("createZone: -> MeshFilter.set_sharedMesh");
    _0x1cf549(_0x1ca111, _0x473139, NULL);
    _0x13ee08("createZone: <- MeshFilter.set_sharedMesh");
    _0x13ee08("createZone: -> ensureSharedMaterial");
    let _0x7a9a59 = _0x4bbf43();
    _0x13ee08("createZone: <- ensureSharedMaterial null=" + _0x7a9a59.isNull());
    if (!_0x7a9a59.isNull()) {
      _0x39ae42(_0x41dd9e, _0x7a9a59, NULL);
    }
    _0x13ee08("createZone: -> Renderer.set_enabled");
    _0x68f14c(_0x41dd9e, 1, NULL);
    _0x13ee08("createZone: <- Renderer.set_enabled");
    _0x13ee08("createZone: -> Component.get_transform(MeshFilter)");
    let _0x5764f4 = _0x484914(_0x1ca111, NULL);
    _0x13ee08("createZone: <- get_transform tf=" + _0x5764f4);
    if (_0x5764f4.isNull()) {
      return "failed to get transform";
    }
    if (!_0x149931) {
      let _0x4d6056 = _0x484914(_0x390ac2, NULL);
      _0x13ee08("createZone: -> Transform.SetParent playerTf=" + _0x4d6056);
      if (!_0x4d6056.isNull()) {
        _0x5d8775(_0x5764f4, _0x4d6056, NULL);
      }
      _0x13ee08("createZone: <- SetParent");
    }
    let _0x1fdecf = Memory.alloc(12);
    _0x1fdecf.writeFloat(_0x149931 ? _0x149931[0] : 0);
    _0x1fdecf.add(4).writeFloat((_0x149931 ? _0x149931[1] : 0) + _0x34a399);
    _0x1fdecf.add(8).writeFloat(_0x149931 ? _0x149931[2] : 0);
    let _0x468b94 = _0x21920e(_0x5764f4);
    if (_0x468b94.isNull()) {
      return "transform has no native object";
    }
    _0x13ee08("createZone: -> set_localPosition_Injected native=" + _0x468b94);
    _0x47e27b(_0x468b94, _0x1fdecf, NULL);
    _0x13ee08("createZone: <- set_localPosition_Injected");
    let _0x4a2223 = _0x5212d5(_0x390ac2, NULL);
    if (!_0x4a2223.isNull()) {
      let _0x4bd8a7 = _0x20c223(_0x4a2223, NULL);
      _0x13ee08("createZone: -> set_layer " + _0x4bd8a7);
      _0x416720(_0x3e15fe, _0x4bd8a7, NULL);
      _0x13ee08("createZone: <- set_layer");
    }
    _0x13ee08("createZone: DONE id=" + _0x4a29f4);
    _0x5a5014.set(_0x4a29f4, {
      go: _0x3e15fe,
      tf: _0x5764f4,
      mesh: _0x473139,
      renderer: _0x41dd9e,
      radius: _0x9048a9,
      rgba: _0x44a7b3,
      world: _0x149931,
      line: _0x59df25
    });
    return null;
  }
  function _0x13e37d(_0x55d980, _0x27d590, _0xe72357, _0x577043, _0x5f511f) {
    if (!_0x44669c) {
      return "zone offsets not loaded";
    }
    let _0xd67dab = _0x5a5014.get(_0x55d980);
    if (!_0xd67dab) {
      return "zone not found: " + _0x55d980;
    }
    if (!_0x3a58ba(_0xd67dab.go)) {
      _0x5a5014.delete(_0x55d980);
      return "zone was destroyed: " + _0x55d980;
    }
    let _0x42e236 = _0xe72357 || _0xd67dab.rgba;
    let _0x4ab132 = _0x5f511f || _0xd67dab.line;
    if (_0x4ab132) {
      _0x24164f(_0xd67dab.mesh, _0x4ab132[0], _0x4ab132[1], _0x4ab132[2], _0x4ab132[3], _0x42e236[0], _0x42e236[1], _0x42e236[2], _0x42e236[3]);
    } else {
      _0x1e53fe(_0xd67dab.mesh, _0x27d590, _0x42e236[0], _0x42e236[1], _0x42e236[2], _0x42e236[3]);
    }
    _0xd67dab.radius = _0x27d590;
    _0xd67dab.rgba = _0x42e236;
    _0xd67dab.line = _0x4ab132;
    if (_0x577043) {
      if (!_0xd67dab.world) {
        return "zone " + _0x55d980 + " follows the character and cannot be moved";
      }
      let _0x2936a7 = Memory.alloc(12);
      _0x2936a7.writeFloat(_0x577043[0]);
      _0x2936a7.add(4).writeFloat(_0x577043[1] + _0x34a399);
      _0x2936a7.add(8).writeFloat(_0x577043[2]);
      let _0x130bb9 = _0x21920e(_0xd67dab.tf);
      if (_0x130bb9.isNull()) {
        return "transform has no native object";
      }
      _0x47e27b(_0x130bb9, _0x2936a7, NULL);
      _0xd67dab.world = _0x577043;
    }
    return null;
  }
  function _0x396f47(_0x57161e) {
    let _0x119f1a = _0x5a5014.get(_0x57161e);
    if (_0x119f1a) {
      if (_0x3a58ba(_0x119f1a.go) && _0x1ee86b !== null) {
        _0x1ee86b(_0x119f1a.go, NULL);
      }
      _0x5a5014.delete(_0x57161e);
    }
    return null;
  }
  var _0x1b48b4 = null;
  var _0x371e20 = false;
  var _0xf44ff4 = [];
  var _0x4ed5f9 = "offsets not applied";
  var _0x480cd9 = 0;
  var _0xce1704 = null;
  var _0x2995be = new _0x57ef97();
  var _0x76d7c1 = "Radar array TypeInfo is unresolved; waiting for game metadata";
  var _0x297eff = {
    x: 0,
    y: 0,
    z: 0,
    ageMs: 0
  };
  var _0xed6687 = {
    nativeReady: false,
    loading: null,
    loadingAgeMs: null,
    self: null
  };
  function _0x5d5934() {
    if (_0x1b48b4 !== null && !!_0x1b48b4.active() && off !== null && (_0x480cd9 = 0, !!_0x52d1d0 && !_0x390ac2.isNull() && _0x15d7f3.loadingValue === false)) {
      try {
        let pcActorMovePtr = _0x390ac2.add(off.pcActorMove).readPointer();
        if (pcActorMovePtr.isNull()) {
          return;
        }
        let gaPositionAddr = pcActorMovePtr.add(off.gaPosition);
        let _0x4fb992 = gaPositionAddr.readFloat();
        let _0x4e9427 = gaPositionAddr.add(4).readFloat();
        let _0x36b99d = gaPositionAddr.add(8).readFloat();
        if (!Number.isFinite(_0x4fb992) || !Number.isFinite(_0x4e9427) || !Number.isFinite(_0x36b99d)) {
          return;
        }
        _0x297eff.x = _0x4fb992;
        _0x297eff.y = _0x4e9427;
        _0x297eff.z = _0x36b99d;
        _0x480cd9 = Date.now();
      } catch {
        _0x480cd9 = 0;
      }
    }
  }
  function _0x276f6d() {
    let _0x209107 = Date.now();
    _0x297eff.ageMs = _0x209107 - _0x480cd9;
    _0xed6687.nativeReady = _0x52d1d0 && _0x480cd9 > 0 && _0x209107 >= _0x480cd9;
    _0xed6687.loading = _0x15d7f3.loadingValue;
    _0xed6687.loadingAgeMs = _0x15d7f3.loadingAge(_0x209107);
    _0xed6687.self = _0x480cd9 > 0 ? _0x297eff : null;
    return _0xed6687;
  }
  function _0x3ba549() {
    if (_0xce1704 !== null) {
      clearInterval(_0xce1704);
      _0xce1704 = null;
    }
    _0x2995be.cancel();
  }
  function _0x10aaed(_0x29e446) {
    _0x3ba549();
    if (_0x1b48b4 !== null) {
      _0x1b48b4.dispose();
    }
    _0x1b48b4 = null;
    _0x371e20 = false;
    _0xf44ff4 = [];
    _0x4ed5f9 = _0x29e446;
    _0x480cd9 = 0;
  }
  function _0xdc8a70(off2) {
    let _0x4b92b8 = [off2.tiRadarVector3Array, off2.tiRadarColorArray, off2.tiRadarIntArray];
    if (!_0x5bc88a(_0x4b92b8, _0xdb6669, Process.pointerSize)) {
      throw new Error("Radar array TypeInfo is outside the module");
    }
    let _0x345c3a = [];
    for (let _0x318074 of _0x4b92b8) {
      let _0x51356c = _0x9ca124.add(_0x318074).readPointer();
      if (!_0x5a8e4e(_0x51356c)) {
        return null;
      }
      _0x345c3a.push(_0x51356c);
    }
    return _0x345c3a;
  }
  function _0x3ffa7f(_0x2af7e3, _0x108993) {
    send({
      t: "radar_readiness",
      ready: _0x2af7e3,
      reason: _0x334def(_0x108993),
      missing: _0xf44ff4
    });
  }
  function _0x427de6(off2) {
    _0x4ed5f9 = _0x76d7c1;
    let _0x452f0d = _0x2995be.begin(Date.now());
    let _0xec8709 = off;
    let _0x5029cb = _0x9ca124;
    _0x3ffa7f(false, _0x4ed5f9);
    _0xce1704 = setInterval(() => {
      if (_0x2995be.claimPoll(_0x452f0d, Date.now())) {
        if (off !== _0xec8709) {
          _0x10aaed("offset table replaced");
          return;
        }
        try {
          let _0x558c78 = Process.findModuleByName(off2.module);
          if (_0x558c78 === null || !_0x558c78.base.equals(_0x5029cb)) {
            throw new Error("Radar module owner changed while metadata was pending");
          }
          if (_0xdc8a70(off2) === null || !_0x2995be.finish(_0x452f0d)) {
            return;
          }
          clearInterval(_0xce1704);
          _0xce1704 = null;
          _0x2ca1db();
          if (_0x371e20) {
            _0x3ffa7f(true, "");
          } else {
            _0x3ffa7f(false, _0x4ed5f9);
          }
        } catch (_0x57b3e0) {
          _0x10aaed("radar readiness retry failed: " + _0x57b3e0);
          _0x3ffa7f(false, _0x4ed5f9);
        }
      }
    }, 500);
  }
  function _0x2ca1db() {
    _0x10aaed("offsets not applied");
    if (off === null) {
      return;
    }
    let off2 = off;
    _0xf44ff4 = [..._0xa44dd5(off2, KEYS_RADAR2), ..._0xa44dd5(off2, KEYS_MESH), ..._0xa44dd5(off2, KEYS_SCENE_LOADER)];
    if (_0xf44ff4.length > 0) {
      _0x4ed5f9 = "radar, mesh, or loading offsets missing";
      return;
    }
    if (!_0x33d100 || !_0x44669c || !_0x52d1d0) {
      _0x4ed5f9 = "radar mesh/snapshot dependencies unavailable";
      return;
    }
    try {
      if (!_0x33ac51() || _0xc1f0b3 === null) {
        throw new Error("Radar il2cpp exports unavailable");
      }
      let _0x4ce0b0 = Process.findModuleByName(off2.module);
      if (_0x4ce0b0 === null) {
        throw new Error("Radar module unavailable");
      }
      let _0x36df39 = _0x2f4e0c(_0x4ce0b0, "il2cpp_array_new_specific");
      let _0x52fedd = _0x2f4e0c(_0x4ce0b0, "il2cpp_gchandle_free");
      if (_0x36df39.isNull() || _0x52fedd.isNull()) {
        throw new Error("Radar array/root exports unavailable");
      }
      let _0x2b09b2 = new NativeFunction(_0x36df39, "pointer", ["pointer", "ulong"]);
      let _0x4d6e66 = new NativeFunction(_0x52fedd, "void", ["uint"]);
      let _0x53ef60 = _0xc1f0b3;
      let _0x3b1ab4 = _0xdc8a70(off2);
      if (_0x3b1ab4 === null) {
        _0x427de6(off2);
        return;
      }
      let [_0x168ec1, _0x139b57, _0x31c455] = _0x3b1ab4;
      let _0x404123 = _0x9c1407;
      let _0x2f38e9 = _0x3f4ff3;
      let _0x290bb2 = _0x50671e;
      let _0x4b3ba6 = _0x1ee86b;
      let _0x3dcaf5 = _0x68f14c;
      let _0x42f342 = _0x9ca124;
      let _0x1e4ff5 = off2.module;
      let _0x1457f9 = () => {
        let _0x4faca1 = Process.findModuleByName(_0x1e4ff5);
        return _0x4faca1 !== null && _0x4faca1.base.equals(_0x42f342);
      };
      let _0x46b261 = (_0x19d8df, _0x24f10f) => {
        let _0x3ee914 = _0x19d8df;
        if (_0x3ee914.released || !_0x1457f9()) {
          throw new Error("Radar mesh owner is unavailable");
        }
        if (_0x3ee914.entry.go.add(off2.objCachedPtr).readPointer().isNull()) {
          throw new Error("Radar mesh was destroyed by the scene");
        }
        if (_0x24f10f.vertexCount !== _0x3ee914.vertexCount || _0x24f10f.indexCount !== _0x3ee914.indexCount) {
          throw new Error("Radar mesh topology changed");
        }
        _0x3ee914.vertexData.writeByteArray(_0x24f10f.positions.buffer);
        _0x3ee914.colourData.writeByteArray(_0x24f10f.colours.buffer);
        _0x404123(_0x3ee914.entry.mesh, _0x3ee914.vertices, NULL);
        _0x2f38e9(_0x3ee914.entry.mesh, _0x3ee914.colours, NULL);
      };
      _0x1b48b4 = _0x38f334({
        offsets: off2,
        moduleBase: _0x9ca124,
        codeSite: _0x3166d6,
        getSnapshot: _0x276f6d,
        send: _0x5f092f => send(_0x5f092f),
        trace: _0x4efd5b => _0x13ee08(_0x4efd5b),
        animate: true,
        mesh: {
          create(_0x2f97bc, _0x461188, _0x456e27) {
            if (!_0x1457f9() || _0x390ac2.isNull()) {
              return "Radar mesh owner is unavailable";
            }
            if (off2.strideV3 !== 12 || off2.strideColor !== 16 || off2.strideInt !== 4) {
              return "Radar mesh array strides do not match Float32/Int32 buffers";
            }
            let _0x184147 = "__radar-player";
            let _0x5d12e4 = _0x2bc2e2(_0x184147, 1, [0.2, 1, 0.3, 0.25], _0x456e27 === null ? undefined : [_0x456e27.x, _0x456e27.y, _0x456e27.z]);
            if (_0x5d12e4 !== null) {
              return _0x5d12e4;
            }
            let _0x2180f3 = _0x5a5014.get(_0x184147);
            if (_0x2180f3 === undefined) {
              return "Radar mesh bootstrap returned no zone";
            }
            let _0x44a98f = [];
            try {
              let _0x1ea326 = (_0x1b5338, _0x2fd5d5) => {
                let _0x104335 = _0x2b09b2(_0x1b5338, _0x2fd5d5);
                if (_0x104335.isNull()) {
                  throw new Error("Radar managed array allocation failed");
                }
                let _0x5ec5df = _0x53ef60(_0x104335, 1);
                if (_0x5ec5df === 0) {
                  throw new Error("Radar managed array root failed");
                }
                _0x44a98f.push(_0x5ec5df);
                return _0x104335;
              };
              let _0x129d86 = _0x1ea326(_0x168ec1, _0x461188.vertexCount);
              let _0x43aae3 = _0x1ea326(_0x139b57, _0x461188.vertexCount);
              let _0x176a12 = _0x1ea326(_0x31c455, _0x461188.indexCount);
              _0x176a12.add(off2.arrFirst).writeByteArray(_0x461188.indices.buffer);
              let _0x24edd8 = {
                radarMeshHandle: true,
                entry: _0x2180f3,
                roots: _0x44a98f,
                vertices: _0x129d86,
                colours: _0x43aae3,
                vertexData: _0x129d86.add(off2.arrFirst),
                colourData: _0x43aae3.add(off2.arrFirst),
                vertexCount: _0x461188.vertexCount,
                indexCount: _0x461188.indexCount,
                released: false
              };
              _0x46b261(_0x24edd8, _0x461188);
              _0x290bb2(_0x2180f3.mesh, _0x176a12, NULL);
              return _0x24edd8;
            } catch (_0x5df717) {
              try {
                _0x3dcaf5(_0x2180f3.renderer, 0, NULL);
                _0x4b3ba6(_0x2180f3.go, NULL);
              } catch {}
              for (let _0x131df1 of _0x44a98f) {
                _0x4d6e66(_0x131df1);
              }
              if (_0x5a5014.get(_0x184147) === _0x2180f3) {
                _0x5a5014.delete(_0x184147);
              }
              return "Radar mesh creation failed: " + _0x5df717;
            }
          },
          update: _0x46b261,
          setVisible(_0x5113be, _0x484d70) {
            let _0x3738ab = _0x5113be;
            if (_0x3738ab.released || !_0x1457f9()) {
              throw new Error("Radar mesh owner is unavailable");
            }
            if (_0x3738ab.entry.go.add(off2.objCachedPtr).readPointer().isNull()) {
              throw new Error("Radar mesh was destroyed by the scene");
            }
            _0x3dcaf5(_0x3738ab.entry.renderer, _0x484d70 ? 1 : 0, NULL);
          },
          destroy(_0x58853f) {
            let _0x66344e = _0x58853f;
            if (!_0x66344e.released && (_0x66344e.released = true, !!_0x1457f9())) {
              try {
                if (!_0x66344e.entry.go.add(off2.objCachedPtr).readPointer().isNull()) {
                  _0x3dcaf5(_0x66344e.entry.renderer, 0, NULL);
                  _0x4b3ba6(_0x66344e.entry.go, NULL);
                }
              } finally {
                for (let _0x1b9273 of _0x66344e.roots) {
                  _0x4d6e66(_0x1b9273);
                }
                _0x66344e.roots.length = 0;
                if (_0x5a5014.get("__radar-player") === _0x66344e.entry) {
                  _0x5a5014.delete("__radar-player");
                }
              }
            }
          }
        }
      });
      _0x371e20 = _0x1b48b4.available();
      _0x4ed5f9 = _0x371e20 ? "" : _0x1b48b4.status().reason;
      if (!_0x371e20) {
        _0x1b48b4.dispose();
        _0x1b48b4 = null;
      }
    } catch (_0x3d3a07) {
      _0x10aaed("radar initialization failed: " + _0x3d3a07);
    }
  }
  function _0x45678a(_0x3838d1) {
    if (_0x1e0777(_0x3838d1)) {
      if (_0x1b48b4 !== null) {
        _0x1b48b4.command(_0x3838d1);
      } else {
        send({
          t: "zone",
          id: _0x3838d1.id,
          ok: false,
          layout: "radar",
          draw: false,
          material: "idle",
          error: _0x4ed5f9 || "radar unavailable"
        });
      }
      return;
    }
    let _0x38b5cb = _0x3838d1.id || "default";
    if (_0x3838d1.on === false) {
      if (!_0x5b8db7(() => {
        let _0x9803dc = _0x396f47(_0x38b5cb);
        send({
          t: "zone",
          id: _0x38b5cb,
          ok: _0x9803dc === null,
          error: _0x9803dc || undefined
        });
      })) {
        send({
          t: "zone",
          id: _0x38b5cb,
          ok: false,
          error: "frame queue unavailable"
        });
      }
      return;
    }
    if (!_0x5b8db7(() => {
      try {
        let _0x202402 = _0x3838d1.radius || 60;
        let _0x2583bc = [_0x3838d1.r !== undefined ? _0x3838d1.r : 1, _0x3838d1.g !== undefined ? _0x3838d1.g : 0, _0x3838d1.b !== undefined ? _0x3838d1.b : 0, _0x3838d1.a !== undefined ? _0x3838d1.a : 0.25];
        let _0x44af96 = _0x3838d1.x !== undefined && _0x3838d1.y !== undefined && _0x3838d1.z !== undefined ? [_0x3838d1.x, _0x3838d1.y, _0x3838d1.z] : undefined;
        let _0x5009c0 = _0x44af96 !== undefined && _0x3838d1.x2 !== undefined && _0x3838d1.y2 !== undefined && _0x3838d1.z2 !== undefined ? [_0x3838d1.x2 - _0x44af96[0], _0x3838d1.y2 - _0x44af96[1], _0x3838d1.z2 - _0x44af96[2], _0x3838d1.w !== undefined ? _0x3838d1.w : 2] : undefined;
        let _0x3dd9a4 = _0x5a5014.get(_0x38b5cb);
        if (_0x3dd9a4 !== undefined && !_0x3a58ba(_0x3dd9a4.go)) {
          _0x5a5014.delete(_0x38b5cb);
        }
        let _0x293cfd;
        let _0x2008f9 = 0;
        if (_0x5a5014.has(_0x38b5cb)) {
          _0x293cfd = _0x13e37d(_0x38b5cb, _0x202402, _0x3838d1.r !== undefined ? _0x2583bc : undefined, _0x44af96, _0x5009c0);
        } else {
          _0x293cfd = _0x2bc2e2(_0x38b5cb, _0x202402, _0x2583bc, _0x44af96, _0x5009c0);
        }
        if (_0x293cfd === null) {
          let _0x292a71 = _0x5a5014.get(_0x38b5cb);
          if (_0x292a71) {
            _0x2008f9 = _0x2522df(_0x292a71.mesh, NULL);
          }
        }
        send({
          t: "zone",
          id: _0x38b5cb,
          ok: _0x293cfd === null,
          verts: _0x2008f9,
          error: _0x293cfd || undefined
        });
      } catch (_0x596746) {
        send({
          t: "zone",
          id: _0x38b5cb,
          ok: false,
          error: "" + _0x596746
        });
      }
    })) {
      send({
        t: "zone",
        id: _0x38b5cb,
        ok: false,
        error: _0x52d1d0 ? "frame queue full" : "no frame hook"
      });
    }
  }
  function _0x4bc103(_0x4d8205) {
    let _0x181aba = _0x4d8205.id || "default";
    let _0x55a5d7 = _0x4d8205.pts || [];
    if (!_0x43c9d6) {
      send({
        t: "w2s",
        id: _0x181aba,
        ok: false,
        error: "w2s offsets not loaded"
      });
      return;
    }
    if (!_0x5b8db7(() => {
      try {
        if (!_0x314e1d()) {
          send({
            t: "w2s",
            id: _0x181aba,
            ok: false,
            error: "failed to bind camera"
          });
          return;
        }
        let _0x2aee26 = [];
        for (let _0x29fffc of _0x55a5d7) {
          if (_0x29fffc.length < 3) {
            _0x2aee26.push(null);
            continue;
          }
          _0x2aee26.push(_0x1f16d9(_0x29fffc[0], _0x29fffc[1], _0x29fffc[2]));
        }
        send({
          t: "w2s",
          id: _0x181aba,
          ok: true,
          w: _0x95429a,
          h: _0xb637ed,
          screen: _0x2aee26
        });
      } catch (_0x1fc3ab) {
        send({
          t: "w2s",
          id: _0x181aba,
          ok: false,
          error: "" + _0x1fc3ab
        });
      }
    })) {
      send({
        t: "w2s",
        id: _0x181aba,
        ok: false,
        error: _0x52d1d0 ? "frame queue full" : "no frame hook"
      });
    }
  }
  var _0x5411b9 = null;
  function _0x96af7b(_0x203434, _0x141f39, _0x5c266c, _0x9ae89b, _0x277bd3) {
    let off2 = off;
    if (off2 == null || _0x390ac2.isNull()) {
      send({
        t: "moved",
        ok: false,
        error: "no character yet"
      });
      return;
    }
    let _0xf90792 = Date.now();
    if (!_0x5b8db7(() => {
      let _0x37d7a0 = Date.now();
      try {
        let _0x5b9a62 = _0x390ac2;
        if (_0x5b9a62.isNull()) {
          send({
            t: "moved",
            ok: false,
            error: "character went away"
          });
          return;
        }
        let pcActState = _0x5b9a62.add(off2.pcActState).readU32();
        let pcAction = _0x5b9a62.add(off2.pcAction).readU8();
        if ((pcActState & 352) !== 0 || pcAction > 9) {
          send({
            t: "moved",
            ok: false,
            error: "rejected by guard",
            actState: pcActState,
            action: pcAction,
            reason: (pcActState & 352) !== 0 ? "dwActState & 0x160" : "actionEnum > 9"
          });
          return;
        }
        if (_0x5411b9 == null) {
          _0x5411b9 = new NativeFunction(_0x9ca124.add(off2.rvaOnManualMovement), "bool", ["pointer", ["float", "float", "float"], "bool", "pointer"]);
        }
        let _0x384270 = Date.now();
        let _0x119fd7 = _0x5411b9(_0x5b9a62, [_0x203434, _0x141f39, _0x5c266c], _0x277bd3 ? 1 : 0, NULL);
        let _0x2ff065 = Date.now();
        send({
          t: "moved",
          ok: true,
          result: !!_0x119fd7,
          allowFar: _0x277bd3,
          rva: "0x" + off2.rvaOnManualMovement.toString(16),
          target: {
            x: _0x203434,
            y: _0x141f39,
            z: _0x5c266c
          },
          reaction_ms: _0x9ae89b ? _0x2ff065 - _0x313980 : -1,
          wait_ms: _0x37d7a0 - _0xf90792,
          bind_ms: _0x384270 - _0x37d7a0,
          invoke_ms: _0x2ff065 - _0x384270,
          total_ms: _0x2ff065 - _0xf90792,
          via: "frame_hook"
        });
      } catch (_0x30602a) {
        send({
          t: "moved",
          ok: false,
          error: "" + _0x30602a
        });
      }
    })) {
      send({
        t: "moved",
        ok: false,
        error: _0x52d1d0 ? "frame queue is full" : "no frame hook"
      });
    }
  }
  function _0x228f96() {
    let _0x33e79c = null;
    function _0x2c993f() {
      if (_0x33e79c !== null) {
        return _0x33e79c;
      }
      let _0x2e7204 = Process.getModuleByName("libdl.so");
      let _0x1fefb8 = _0x2e7204.getExportByName("dlopen");
      let _0x4159c9 = _0x2e7204.getExportByName("dlsym");
      let _0x4b0aeb = _0x2e7204.getExportByName("dlerror");
      _0x33e79c = {
        dlopen: new NativeFunction(_0x1fefb8, "pointer", ["pointer", "int"]),
        dlsym: new NativeFunction(_0x4159c9, "pointer", ["pointer", "pointer"]),
        dlerror: new NativeFunction(_0x4b0aeb, "pointer", [])
      };
      return _0x33e79c;
    }
    return {
      architecture: Process.arch,
      open(_0x1eba2b, _0x540293) {
        let _0x240d21 = _0x2c993f();
        _0x240d21.dlerror();
        return _0x240d21.dlopen(Memory.allocUtf8String(_0x1eba2b), _0x540293);
      },
      symbol(_0x1aa795, _0x3835f3) {
        let _0x52183a = _0x2c993f();
        _0x52183a.dlerror();
        return _0x52183a.dlsym(_0x1aa795, Memory.allocUtf8String(_0x3835f3));
      },
      isNull(_0x4e0066) {
        return _0x4e0066.isNull();
      },
      invokeVersion(_0xd97e45) {
        return new NativeFunction(_0xd97e45, "uint32", [])();
      },
      invokeAbi(_0x252223) {
        let _0x26ec8f = new NativeFunction(_0x252223, "pointer", [])();
        if (_0x26ec8f.isNull()) {
          return null;
        } else {
          return _0x26ec8f.readUtf8String();
        }
      }
    };
  }
  var _0x6c787 = null;
  var _0x476118 = null;
  var _0x2758db = false;
  function _0x8aeca7(_0x399fc8) {
    let _0x52d1d7 = _0x399fc8 !== null && typeof _0x399fc8 == "object" && typeof _0x399fc8.req == "number" && Number.isInteger(_0x399fc8.req) && _0x399fc8.req >= 1 && _0x399fc8.req <= 2147483647 ? _0x399fc8.req : 0;
    if (_0x52d1d7 === 0) {
      send({
        t: "libshare",
        req: _0x52d1d7,
        ok: false,
        error: "invalid request"
      });
      return;
    }
    try {
      if (_0x6c787 === null) {
        _0x6c787 = _0x337815(_0x228f96());
      }
      let _0x36b25a = _0x6c787.initialize({
        path: _0x399fc8.path,
        sha256: _0x399fc8.sha256,
        package: _0x399fc8.package
      });
      send({
        t: "libshare",
        req: _0x52d1d7,
        ..._0x36b25a
      });
    } catch {
      send({
        t: "libshare",
        req: _0x52d1d7,
        ok: false,
        error: "native loader failure"
      });
    }
  }
  function _0x5aa8c3(_0x5d5923) {
    function _0x576e79(_0x16ec52) {
      let _0x46c420 = _0x5d5923.resolve(_0x16ec52);
      if (_0x46c420 === null) {
        throw new Error("required native license export missing");
      }
      return _0x46c420;
    }
    let _0x4424a8 = new NativeFunction(_0x576e79("capy_license_protocol_version"), "uint32", []);
    let _0x10151b = new NativeFunction(_0x576e79("capy_license_context_create"), "pointer", []);
    let _0x32d951 = new NativeFunction(_0x576e79("capy_license_context_handshake"), "int32", ["pointer", "pointer", "uint32"]);
    let _0x3a0fd6 = new NativeFunction(_0x576e79("capy_license_context_configure"), "int32", ["pointer", "pointer", "uint32"]);
    let _0x3a8b5e = new NativeFunction(_0x576e79("capy_license_context_server"), "int32", ["pointer", "pointer", "uint32"]);
    let _0x54c566 = new NativeFunction(_0x576e79("capy_license_request_start"), "int32", ["pointer", "uint32"]);
    let _0x5acff5 = new NativeFunction(_0x576e79("capy_license_request_poll"), "int32", ["pointer", "uint32", "pointer", "uint32", "pointer"]);
    let _0x24057e = new NativeFunction(_0x576e79("capy_license_request_cancel"), "void", ["pointer", "uint32"]);
    let _0x4cba90 = new NativeFunction(_0x576e79("capy_license_context_destroy"), "void", ["pointer"]);
    return {
      protocolVersion: () => _0x4424a8(),
      create: () => {
        let _0x5a553e = _0x10151b();
        if (_0x5a553e.isNull()) {
          return null;
        } else {
          return _0x5a553e;
        }
      },
      handshake(_0xec496a) {
        let _0x4adb86 = Memory.alloc(113);
        let _0x3e29b5 = _0x32d951(_0xec496a, _0x4adb86, 113);
        if (_0x3e29b5 !== 113) {
          throw _0x3e29b5;
        }
        let _0x1529b0 = _0x4adb86.readByteArray(113);
        if (_0x1529b0 === null) {
          throw -16;
        }
        return new Uint8Array(_0x1529b0);
      },
      configure(_0x447dd7, _0x2f0ae9) {
        let _0x1fffb4 = Memory.alloc(_0x2f0ae9.length);
        _0x1fffb4.writeByteArray(Array.from(_0x2f0ae9));
        return _0x3a0fd6(_0x447dd7, _0x1fffb4, _0x2f0ae9.length);
      },
      server(_0x4fc45c) {
        let _0x5aab31 = Memory.alloc(1025);
        let _0x33fb8a = _0x3a8b5e(_0x4fc45c, _0x5aab31, 1025);
        if (_0x33fb8a <= 0 || _0x33fb8a > 1025) {
          throw _0x33fb8a;
        }
        let _0x5747ab = _0x5aab31.readUtf8String(_0x33fb8a - 1);
        if (_0x5747ab === null) {
          throw -16;
        }
        return _0x5747ab;
      },
      requestStart: (_0x2aae2e, _0x2e3fb2) => _0x54c566(_0x2aae2e, _0x2e3fb2),
      requestPoll(_0x1e3858, _0x2e19ff) {
        let _0x2e0e66 = Memory.alloc(8193);
        let _0x380592 = Memory.alloc(4);
        _0x380592.writeS32(0);
        let _0x107158 = _0x5acff5(_0x1e3858, _0x2e19ff, _0x2e0e66, 8193, _0x380592);
        if (_0x107158 === 0) {
          return {
            pending: true
          };
        }
        if (_0x107158 < 0 || _0x107158 > 8193) {
          throw _0x107158 < 0 ? _0x107158 : -12;
        }
        let _0x5eceb0 = _0x2e0e66.readUtf8String(_0x107158 - 1);
        if (_0x5eceb0 === null) {
          throw -16;
        }
        return {
          pending: false,
          status: _0x380592.readS32(),
          body: _0x5eceb0
        };
      },
      requestCancel: (_0x5e2b2e, _0xcde144) => {
        _0x24057e(_0x5e2b2e, _0xcde144);
      },
      destroy: _0x189781 => {
        _0x4cba90(_0x189781);
      }
    };
  }
  function _0x1aa900() {
    if (_0x2758db) {
      return;
    }
    _0x2758db = true;
    let _0x353813 = Process.getModuleByName("libc.so");
    let _0x57e5fb;
    try {
      _0x57e5fb = _0x353813.getExportByName("_exit");
    } catch {
      _0x57e5fb = _0x353813.getExportByName("exit");
    }
    new NativeFunction(_0x57e5fb, "void", ["int"])(1);
  }
  function _0x5c4be5() {
    if (_0x476118 !== null) {
      return _0x476118;
    }
    if (_0x6c787 === null) {
      return null;
    }
    try {
      _0x476118 = new _0x4b9c86(_0x5aa8c3(_0x6c787), {
        now: () => Date.now(),
        setTimeout: (_0x520c38, _0x158fba) => setTimeout(_0x520c38, _0x158fba),
        clearTimeout: _0x4c3039 => clearTimeout(_0x4c3039),
        send: _0x1c355a => send(_0x1c355a),
        opened: () => {},
        authorization: () => {},
        disposed: () => {},
        terminate: _0x1aa900
      });
      return _0x476118;
    } catch {
      return null;
    }
  }
  function _0x5cf482(_0x286ca7) {
    let _0x5da5a4 = _0x5c4be5();
    if (_0x5da5a4 === null) {
      let _0x15ca07 = Number.isInteger(_0x286ca7?.req) && _0x286ca7.req >= 1 && _0x286ca7.req <= 2147483647 ? _0x286ca7.req : 0;
      send({
        t: "license_hello",
        req: _0x15ca07,
        ok: false,
        error: "native_unavailable"
      });
      return;
    }
    _0x5da5a4.open(_0x286ca7, Process.id);
  }
  function _0x12000d(_0x4f4c4d) {
    let _0x4985d9 = _0x476118;
    if (_0x4985d9 === null) {
      let _0x2f32ea = Number.isInteger(_0x4f4c4d?.req) && _0x4f4c4d.req >= 1 && _0x4f4c4d.req <= 2147483647 ? _0x4f4c4d.req : 0;
      send({
        t: "license_bootstrap",
        req: _0x2f32ea,
        sessionId: "",
        ok: false,
        error: "native_unavailable"
      });
      return;
    }
    _0x4985d9.bootstrap(_0x4f4c4d);
  }
  function _0x250926(_0x3d72b6) {
    let _0x5eab74 = _0x476118;
    _0x3ba549();
    _0x44ec3a(() => _0x5eab74?.dispose(_0x3d72b6?.sessionId));
  }
  function _0x405144() {
    _0x225927();
    _0x10aaed("agent disposed");
    _0x476118?.dispose();
    _0x476118 = null;
    _0x6c787?.release();
    _0x6c787 = null;
  }
  function _0x1750f3() {
    _0x3ba549();
    _0x44ec3a(_0x405144);
  }
  function _0x5f4b38(_0x59177e) {
    switch (_0x59177e.cmd) {
      case "libshare_init":
        _0x8aeca7(_0x59177e);
        break;
      case "license_open":
        _0x5cf482(_0x59177e);
        break;
      case "license_bootstrap":
        _0x12000d(_0x59177e);
        break;
      case "license_dispose":
        _0x250926(_0x59177e);
        break;
      case "hello":
        send({
          t: "hello",
          arch: Process.arch,
          pointerSize: Process.pointerSize,
          pid: Process.id,
          runtime: Script.runtime,
          resolved: off != null
        });
        break;
      case "offsets":
        _0x130f2f(_0x59177e);
        break;
      case "inworld":
        send({
          t: "inworld",
          player: _0x390ac2.toString(),
          handler: _0x298ea0.toString(),
          ok: _0x52d1d0 && !_0x390ac2.isNull() && !_0x298ea0.isNull(),
          frames: _0x5dc799
        });
        break;
      case "census_raw":
        {
          let _0x5b23d6 = _0x59177e.reps || 1;
          if (_0x5b23d6 === 1) {
            _0x467650(_0x59177e.tag || "raw");
            break;
          }
          let _0x240d22 = Date.now();
          let _0x1ac293 = 0;
          let _0x42a015 = 1000000000;
          let _0x44bd78 = 0;
          for (let _0x53b304 = 0; _0x53b304 < _0x5b23d6; _0x53b304++) {
            let _0x22c9e3 = _0x9a7c5f("bench", true);
            _0x44bd78 += _0x22c9e3;
            if (_0x22c9e3 > _0x1ac293) {
              _0x1ac293 = _0x22c9e3;
            }
            if (_0x22c9e3 < _0x42a015) {
              _0x42a015 = _0x22c9e3;
            }
          }
          send({
            t: "census_raw_bench",
            reps: _0x5b23d6,
            total_ms: Date.now() - _0x240d22,
            avg_ms: _0x44bd78 / _0x5b23d6,
            best_ms: _0x42a015,
            worst_ms: _0x1ac293
          });
          _0x9a7c5f(_0x59177e.tag || "raw", false);
          break;
        }
      case "sub":
        _0x1942a0(_0x59177e.tier, _0x59177e.hz);
        send({
          t: "subbed",
          tier: _0x59177e.tier,
          hz: _0x59177e.hz
        });
        break;
      case "unsub":
        _0x9b1c55(_0x59177e.tier);
        send({
          t: "unsubbed",
          tier: _0x59177e.tier,
          skipped: _0x4b6fde[_0x59177e.tier]
        });
        break;
      case "ack":
        _0x118409[_0x59177e.tier] = false;
        break;
      case "pong":
        {
          let _0x3abf16 = _0x4c6f1e[_0x59177e.seq];
          if (_0x3abf16 !== undefined) {
            delete _0x4c6f1e[_0x59177e.seq];
            send({
              t: "rtt",
              seq: _0x59177e.seq,
              ms: Date.now() - _0x3abf16
            });
          }
          break;
        }
      case "ping_start":
        _0x441dbb(_0x59177e.hz);
        break;
      case "mt_start":
        _0x1b5e60(_0x59177e.hz);
        break;
      case "arm_reaction":
        _0x49db6d = true;
        break;
      case "move":
        _0x96af7b(_0x59177e.x, _0x59177e.y, _0x59177e.z, !!_0x59177e.reaction, _0x59177e.flag === undefined ? true : !!_0x59177e.flag);
        break;
      case "buffs":
        {
          let _0xcaf0b7 = _0x59177e.ids || [];
          let _0x30f33f = {};
          if (_0xcaf0b7.length === 0) {
            _0x30f33f.self = _0x4858e7();
          } else {
            for (let _0x5026c4 of _0xcaf0b7) {
              _0x30f33f[_0x5026c4] = _0xfcabb1(_0x5026c4);
            }
          }
          send({
            t: "buffs",
            buffs: _0x30f33f
          });
          break;
        }
      case "frame_hook":
        if (_0x59177e.on === false) {
          _0x3ba549();
          _0x44ec3a(() => {
            _0x5cd659();
            send({
              t: "frame_hook",
              active: false
            });
          });
          break;
        }
        if (_0x2a51b7 && _0x52d1d0) {
          _0x25cf34 = true;
        }
        send({
          t: "frame_hook",
          active: _0x52d1d0,
          method: "anchors"
        });
        break;
      case "frame_stats":
        send({
          t: "frame_stats",
          active: _0x52d1d0,
          method: "anchors",
          queued: _0x578e43.length,
          run: _0x14e42c,
          failed: _0x57ca44,
          frames: _0x5dc799,
          handler: _0x298ea0.toString(),
          player: _0x390ac2.toString()
        });
        break;
      case "frame_unhook":
        _0x3ba549();
        _0x44ec3a(() => {
          _0x5cd659();
          send({
            t: "frame_unhooked"
          });
        });
        break;
      case "forget_names":
        for (let _0x73965f of Object.keys(_0x31b02d)) {
          delete _0x31b02d[_0x73965f];
        }
        for (let _0x53cb9f of Object.keys(_0x3ec545)) {
          delete _0x3ec545[_0x53cb9f];
        }
        for (let _0x19a04f of Object.keys(_0x4d1e66)) {
          delete _0x4d1e66[_0x19a04f];
        }
        send({
          t: "forgot_names"
        });
        break;
      case "stop_all":
        _0x9b1c55("t0");
        _0x9b1c55("t1");
        _0x9b1c55("t2");
        if (_0x36ddc8 != null) {
          clearInterval(_0x36ddc8);
          _0x36ddc8 = null;
        }
        if (_0x5c8599 != null) {
          clearInterval(_0x5c8599);
          _0x5c8599 = null;
        }
        if (_0x1b48b4 !== null) {
          _0x1b48b4.stop();
        }
        _0x480cd9 = 0;
        if (_0x548284 !== null) {
          _0x548284.suspend();
        }
        _0x44ec3a(() => {});
        send({
          t: "stopped",
          skipped: _0x4b6fde
        });
        break;
      case "radar_mode":
        if (_0x59177e.on === true) {
          if (_0x1b48b4 === null && _0xce1704 === null) {
            _0x2ca1db();
          }
        } else {
          _0x10aaed("classic zone selected");
        }
        _0x3ffa7f(_0x371e20, _0x4ed5f9);
        break;
      case "zone":
        _0x45678a(_0x59177e);
        break;
      case "w2s":
        _0x4bc103(_0x59177e);
        break;
      case "w2s_forget":
        _0x257f0c();
        send({
          t: "w2s_forgot"
        });
        break;
      case "cam":
        {
          let _0x24aff2 = _0x59177e.on === false ? _0x36afe3() : _0x3bdbda(_0x59177e.ceiling === undefined ? 1000 : _0x59177e.ceiling, _0x59177e.topRadius === undefined ? 5 : _0x59177e.topRadius);
          if (_0x24aff2 !== null) {
            send({
              t: "cam",
              ok: false,
              error: _0x24aff2
            });
          }
          break;
        }
      case "cam_zoom":
        {
          if (!_0x3aa646 || _0x548284 === null) {
            send({
              t: "cam_zoom",
              ok: false,
              error: "camera offsets not loaded",
              req: _0x59177e.req === undefined ? 0 : _0x59177e.req,
              ready: false
            });
            break;
          }
          let _0x2f7080 = _0x548284.request(_0x59177e);
          if (_0x2f7080 !== null) {
            send(_0x2f7080);
          }
          break;
        }
      case "cam_zoom_status":
        {
          if (_0x548284 !== null) {
            _0x548284.resume();
          }
          let _0x1e2dd7 = _0x3aa646 && _0xc76a1(off) !== null;
          if (_0x2a51b7 && _0x1e2dd7 && !_0x8df09b) {
            _0x25cf34 = true;
          }
          let _0x25c4e3 = _0x1e2dd7 ? _0x548284.actual() : null;
          if (_0x1e2dd7 && _0x25c4e3 === null) {
            _0x548284.reportNextFrame();
          }
          let _0x5f1fc6 = _0x3a671a === null ? {
            applied: false,
            error: _0x294766
          } : _0x3a671a.status();
          send({
            t: "cam_zoom_status",
            ready: _0x3aa646,
            anchored: _0x1e2dd7,
            reason: _0x46bd9a,
            fogReady: _0x2a51b7,
            fogApplied: _0x5f1fc6.applied,
            fogError: _0x5f1fc6.error,
            fogFrames: _0x481397,
            fogWrites: _0x2b50d5,
            zoom: _0x25c4e3 === null ? undefined : _0x25c4e3.zoom,
            raw: _0x25c4e3 === null ? undefined : _0x25c4e3.raw
          });
          break;
        }
      case "slot":
        _0x18ac83(_0x59177e.use === undefined ? 0 : _0x59177e.use);
        break;
      case "slot_status":
        send({
          t: "slot_status",
          ready: _0x120c62,
          missing: _0x4af91f,
          reason: _0x5aa6c0,
          anchored: !_0x38ac97.isNull()
        });
        break;
      case "attack":
        _0x202ef9(_0x59177e.id === undefined ? -1 : _0x59177e.id, _0x59177e.press !== false);
        break;
      case "attack_stop":
        _0x32c20a();
        break;
      case "party_select":
        _0x4cd8d9(_0x59177e.id, _0x59177e.self === true);
        break;
      case "party_status":
        send({
          t: "party_status",
          ready: _0x479475,
          missing: _0x42ca90,
          reason: _0x55ce49,
          roster: _0x67647e,
          anchored: !_0x32d5da.isNull()
        });
        break;
      case "attack_status":
        send({
          t: "attack_status",
          ready: _0x1ca03c,
          missing: _0x561396,
          reason: _0xcf39b4,
          anchored: !_0x16d9be.isNull()
        });
        break;
      case "skill":
        _0x5d268f(Array.isArray(_0x59177e.slots) ? _0x59177e.slots : []);
        break;
      case "skill_bar":
        _0x456a04();
        break;
      case "skill_check":
        _0x1c3c82(Array.isArray(_0x59177e.slots) ? _0x59177e.slots : []);
        break;
      case "skill_ready":
        _0x229c2f(Array.isArray(_0x59177e.ids) ? _0x59177e.ids : []);
        break;
      case "skill_status":
        send({
          t: "skill_status",
          ready: _0xfeda7a,
          missing: _0x21193b,
          reason: _0x11dcc0,
          anchored: !_0x5e47fc.isNull(),
          set: _0x564b59()
        });
        break;
      case "skill_tab_ids":
        _0x4b61a6(_0x59177e.tab === undefined ? 0 : _0x59177e.tab);
        break;
      case "bag":
        _0x5975c9();
        break;
      case "pet_read":
        send({
          t: "pet_read",
          state: _0x2a8986(),
          ready: _0x120702,
          missing: _0x335116,
          reason: _0x38c3ed
        });
        break;
      case "pet":
        _0x35efde(_0x59177e);
        break;
      case "pet_status":
        send({
          t: "pet_status",
          ready: _0x120702,
          missing: _0x335116,
          reason: _0x38c3ed,
          busy: _0x109505.busy,
          anchored: !_0x53c8d0.isNull()
        });
        break;
      case "sell":
        _0x4c083b(_0x59177e.npc, _0x59177e.items);
        break;
      case "recall":
        _0x3e409b(_0x59177e.ord, _0x59177e.main, _0x59177e.sub);
        break;
      case "friend_warp":
        _0x4aaeb0(_0x59177e.name, _0x59177e.ord, _0x59177e.main, _0x59177e.sub);
        break;
      case "friends":
        _0x1c2222();
        break;
      case "buff_cast":
        _0xe913d1(_0x59177e.slot === undefined ? 0 : _0x59177e.slot, _0x59177e.main === undefined ? -1 : _0x59177e.main, _0x59177e.sub === undefined ? -1 : _0x59177e.sub);
        break;
      case "pick":
        _0x31fef9(_0x59177e.type === undefined ? -1 : _0x59177e.type, _0x59177e.id === undefined ? 0 : _0x59177e.id, _0x59177e.req === undefined ? 0 : _0x59177e.req);
        break;
      case "pick_status":
        send({
          t: "pick_status",
          ready: _0x210b66,
          missing: _0x51bb09,
          reason: _0x511771,
          anchored: !_0x53c8d0.isNull()
        });
        break;
      case "rebirth":
        _0x45cdfd(_0x59177e.mode, _0x59177e.req);
        break;
      case "challenge_answer":
        _0x5dda7f(_0x59177e.req === undefined ? 0 : _0x59177e.req, _0x59177e.challengeId === undefined ? 0 : _0x59177e.challengeId, _0x59177e.answer === undefined ? "" : _0x59177e.answer);
        break;
      case "challenge_answer_status":
        send({
          t: "challenge_answer_status",
          ready: _0x3b379a,
          missing: _0x43b4ce,
          reason: _0x46bd97,
          anchored: _0x52d1d0,
          scm: !_0x53c8d0.isNull()
        });
        break;
      case "rebirth_status":
        send({
          t: "rebirth_status",
          ready: _0x3845a7,
          missing: _0x598183,
          reason: _0xa669d5,
          busy: _0x176816.busy,
          anchored: !_0x53c8d0.isNull()
        });
        break;
      case "cam_status":
        send({
          t: "cam_status",
          ready: _0x3aa646,
          missing: _0x18794e,
          reason: _0x46bd9a,
          anchored: _0x369dae,
          holding: _0x8b4a0e !== null,
          patched: Object.keys(_0x33963e).length
        });
        break;
      case "zone_status":
        send({
          t: "zone_status",
          radar: _0x1b48b4 === null ? {
            ready: _0x371e20,
            reason: _0x4ed5f9,
            draw: false
          } : _0x1b48b4.status(),
          ready: _0x44669c,
          missing: _0x8ea0f0,
          reason: _0x74250c,
          zonetopReady: _0x569b58,
          zonetopMissing: _0x27f61a,
          onTop: _0x548f62,
          zones: Array.from(_0x5a5014.keys()),
          count: _0x5a5014.size
        });
        break;
      default:
        send({
          t: "error",
          error: "unknown cmd " + _0x59177e.cmd
        });
    }
  }
  function _0x3323d4() {
    recv(function (_0x138b56) {
      try {
        _0x5f4b38(_0x138b56);
      } catch (_0x4cef2c) {
        send({
          t: "error",
          error: "" + _0x4cef2c
        });
      }
      _0x3323d4();
    });
  }
  var _0x11989c = {};
  var _0x3e77d6 = Symbol();
  globalThis[_0x3e77d6] = _0x11989c;
  Script.bindWeak(_0x11989c, () => _0x1750f3());
  _0x3323d4();
  send({
    t: "ready",
    runtime: Script.runtime
  });
})();