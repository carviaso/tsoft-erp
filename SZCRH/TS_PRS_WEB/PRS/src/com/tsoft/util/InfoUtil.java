package com.tsoft.util;

import java.lang.reflect.Method;
import java.util.Map;

import com.tsoft.exception.BusinessException;

import freemarker.template.utility.StringUtil;

public class InfoUtil {
	
	public static void  mapResultToInfo(Object o,Map<String,Object> m) throws BusinessException  
	{
		try {
			for(String key:m.keySet())
			{
				StringBuffer methodName = new StringBuffer("set");
				methodName  = methodName.append(StringUtil.capitalize(String.valueOf(key.charAt(0)))); 
				methodName.append(key.substring(1));
			
				Class<? extends Object> c = o.getClass(); 
				Method[] ms = c.getMethods(); 
				for(int i=0;i<ms.length;i++)
				{
				
					String name = ms[i].getName();
					if(name.startsWith("set"))
					{
						String skey = Character.toLowerCase(name.charAt(3)) + name.substring(4); 
						if(m.containsKey(skey))
						{
						
							ms[i].invoke(o,new Object[]{m.get(skey)});
						
						}
					}
				}

			}
		} catch (Exception e) {
			throw new BusinessException(e.getMessage());
		}  
		 
	}
}
