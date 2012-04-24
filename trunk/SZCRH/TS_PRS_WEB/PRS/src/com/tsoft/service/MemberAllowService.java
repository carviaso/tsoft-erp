package com.tsoft.service;

import java.util.List;

import com.tsoft.Info.MemberAllowInfo;
import com.tsoft.Info.MembersInfo;

public interface MemberAllowService {

	public List<MemberAllowInfo> getMemberAllow(MembersInfo mi);
}
